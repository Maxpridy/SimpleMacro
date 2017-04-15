using System;
using System.Windows.Forms;
using EventHook;
//using Nito.AsyncEx;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SimpleMacro
{
    public partial class MacroForm : Form
    {
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte vk, byte scan, int flags, ref int extrainfo);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, IntPtr dwExtraInfo);

        public MacroForm()
        {
            InitializeComponent();
        }

        private void MacroForm_Load(object sender, EventArgs e)
        {
            // 키자마자 실행됨. 창뜨는거보다 먼저
        }

        // 추가 : 여기선 정보에 맞게 추가할 수 있어야함.
        // 받을 정보는 명령이 내려지는 시간(시작을 0기준), 명령타입, 좌표값
        // 추가를 누르면 밑 리스트에 한줄 추가되어야함.
        private void Macro_Addmacro_Click(object sender, EventArgs e)
        {
            AddandEdit addandedit = new AddandEdit();
            if (addandedit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String[] _rowdata = { addandedit.Time, addandedit.Instruction, addandedit.KeyorCoordinate };
                ListViewItem _row = new ListViewItem(_rowdata);

                Macro_Macrodata.Items.Add(_row);
            }
        }

        // 편집
        // 체크된것을 위와 같은 체크박스에서 수정해야됨
        private void Macro_Editmacro_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Macro_Macrodata.CheckedItems)
            {
                AddandEdit addandedit = new AddandEdit();
                addandedit.edittxt(Macro_Macrodata.Items[item.Index].SubItems[0].Text, Macro_Macrodata.Items[item.Index].SubItems[1].Text, Macro_Macrodata.Items[item.Index].SubItems[2].Text);
                if (addandedit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    Macro_Macrodata.Items[item.Index].SubItems[0].Text = addandedit.Time;
                    Macro_Macrodata.Items[item.Index].SubItems[1].Text = addandedit.Instruction;
                    Macro_Macrodata.Items[item.Index].SubItems[2].Text = addandedit.KeyorCoordinate;
                }
            }
        }

        // 삭제
        // 단순하게 체크된걸 삭제함.
        private void Macro_Deletemacro_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Macro_Macrodata.CheckedItems)
            {
                Macro_Macrodata.Items.Remove(item);
            }
        }

        // 기능
        // 여기에는 매크로에 대한 기능이들어가는데
        // 원본에는 파일에 저장하기, 파일로부터 불러오기, 
        // 마우스이동이벤트 반으로줄이기, 마우스이벤트 제거하기 네가지가있다.
        private void Macro_Functionmacro_Click(object sender, EventArgs e)
        {

        }


        // 여기선 밑에 리스트에 있는것을 데이터로 받아서 실행해야됨.
        private void Macro_Playmacro_Click(object sender, EventArgs e)
        {
            try
            {
                Enabled_false();
                _count = Int32.Parse(_Repeat_Count.Text);
                _stop_flag = 0;

                if (_count == 0)
                {
                    _count = 100;
                }
                for (int i = 0; i < _count; i++)
                {
                    if (_Repeat_Count.Text == "0")
                    {
                        i = 0;
                    }
                    Stopwatch sw = new Stopwatch();
                    sw.Start();

                    KeyboardWatcher.Start();
                    KeyboardWatcher.OnKeyInput += (s, ke) =>
                    {
                        // 멈춤 설정
                        if (ke.KeyData.Keyname == "Pause")
                        {
                            _stop_flag = 1;
                            KeyboardWatcher.Stop();
                            sw.Stop();
                            Enabled_true();
                        }
                    };

                    for (int _numofdata = 0; _numofdata < Macro_Macrodata.Items.Count; _numofdata++)
                    {
                        /* 비동기
                        var Wait = Task.Factory.StartNew(() =>
                        {
                            AwaitTime(sw, _numofdata);
                        });

                        await Task.WhenAll(Wait);

                        var Play = Task.Factory.StartNew(() =>
                        {
                            Keyboard_Play(_numofdata);
                            Mouse_Play(_numofdata);
                        });
                        
                        await Task.WhenAll(Play);
                         */


                        AwaitTime(sw, _numofdata);

                        if (_stop_flag == 1)
                        {
                            MessageBox.Show("Stop.");
                            break;
                        }

                        Keyboard_Play(_numofdata);
                        Mouse_Play(_numofdata);

                    }
                    if (_stop_flag == 1)
                    {
                        return;
                    }
                }

                

            }
            catch
            {
                MessageBox.Show("Please input number.");
                Enabled_true();
                return;
            }
            Enabled_true();
        }
        /*
        private void AwaitTime(Stopwatch sw, int _numofdata)
        {
            this.Invoke(new Action(delegate ()
            {
                for (;;)
                {

                    if (Int32.Parse(sw.ElapsedMilliseconds.ToString()) >= Int32.Parse(Macro_Macrodata.Items[_numofdata].SubItems[0].Text))
                    {
                        break;
                    }
                }
            }));
        }*/
        private void AwaitTime(Stopwatch sw, int _numofdata)
        {
            for (;;)
            {

                if (Int32.Parse(sw.ElapsedMilliseconds.ToString()) >= Int32.Parse(Macro_Macrodata.Items[_numofdata].SubItems[0].Text))
                {
                    break;
                }
            }
        }
        /*
        private void Keyboard_Play(int _numofdata)
        {
            int info = 0;
            this.Invoke(new Action(delegate ()
            {
                if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text.Substring(0, 3) == "키보드")
                {
                    // 데이터를 받아서 실행한다.
                    if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "키보드 누름")
                    {
                        keybd_event((byte)Int32.Parse(Macro_Macrodata.Items[_numofdata].SubItems[2].Text), 0, 0, ref info);
                        //keybd_event((byte)Int32.Parse(Macro_Macrodata.Items[_numofdata].SubItems[2].Text), 0, 0, ref info);
                    }

                    if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "키보드 뗌")
                    {
                        keybd_event((byte)Int32.Parse(Macro_Macrodata.Items[_numofdata].SubItems[2].Text), 0, 2, ref info);
                    }

                }
            }));
        }*/
        private void Keyboard_Play(int _numofdata)
        {
            int info = 0;
            if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text.Substring(0, 3) == "키보드")
            {
                // 데이터를 받아서 실행한다.
                if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "키보드 누름")
                {
                    keybd_event((byte)Int32.Parse(Macro_Macrodata.Items[_numofdata].SubItems[2].Text), 0, 0, ref info);
                    //keybd_event((byte)Int32.Parse(Macro_Macrodata.Items[_numofdata].SubItems[2].Text), 0, 0, ref info);
                }

                if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "키보드 뗌")
                {
                    keybd_event((byte)Int32.Parse(Macro_Macrodata.Items[_numofdata].SubItems[2].Text), 0, 2, ref info);
                }

            }
        }
        /*
        private void Mouse_Play(int _numofdata)
        {
            this.Invoke(new Action(delegate ()
            { 
                double Absol = 65535; // 65535 권장
                double _Width = Screen.PrimaryScreen.Bounds.Width;
                double _Height = Screen.PrimaryScreen.Bounds.Height;

                if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text.Substring(0,3) == "마우스")
                {
                    // 이동
                    string coord = Macro_Macrodata.Items[_numofdata].SubItems[2].Text;
                    string[] coordxy = coord.Split(' ');
                    double coord_x = Absol / _Width * Double.Parse(coordxy[0]);
                    double coord_y = Absol / _Height * Double.Parse(coordxy[1]);

                    if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "마우스 이동")
                    {
                        mouse_event(0x8000 | 0x0001, (int)coord_x, (int)coord_y, 0, IntPtr.Zero);
                    }

                    // 좌클릭
                    else if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "마우스 왼쪽 버튼 누름")
                    {
                        mouse_event(0x8000 | 0x0002, (int)coord_x, (int)coord_y, 0, IntPtr.Zero);
                    }

                    else if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "마우스 왼쪽 버튼 뗌")
                    {
                        mouse_event(0x8000 | 0x0004, (int)coord_x, (int)coord_y, 0, IntPtr.Zero);
                    }

                    // 우클릭
                    else if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "마우스 오른쪽 버튼 누름")
                    {
                        mouse_event(0x8000 | 0x0008, (int)coord_x, (int)coord_y, 0, IntPtr.Zero);
                    }

                    else if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "마우스 오른쪽 버튼 뗌")
                    {
                        mouse_event(0x8000 | 0x0010, (int)coord_x, (int)coord_y, 0, IntPtr.Zero);
                    }
                }
            })) ;
        }
        */
        private void Mouse_Play(int _numofdata)
        {
            double Absol = 65535; // 65535 권장
            double _Width = Screen.PrimaryScreen.Bounds.Width;
            double _Height = Screen.PrimaryScreen.Bounds.Height;

            if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text.Substring(0, 3) == "마우스")
            {
                // 이동
                string coord = Macro_Macrodata.Items[_numofdata].SubItems[2].Text;
                string[] coordxy = coord.Split(' ');
                double coord_x = Absol / _Width * Double.Parse(coordxy[0]);
                double coord_y = Absol / _Height * Double.Parse(coordxy[1]);

                if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "마우스 이동")
                {
                    mouse_event(0x8000 | 0x0001, (int)coord_x, (int)coord_y, 0, IntPtr.Zero);
                }

                // 좌클릭
                else if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "마우스 왼쪽 버튼 누름")
                {
                    mouse_event(0x8000 | 0x0002, (int)coord_x, (int)coord_y, 0, IntPtr.Zero);
                }

                else if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "마우스 왼쪽 버튼 뗌")
                {
                    mouse_event(0x8000 | 0x0004, (int)coord_x, (int)coord_y, 0, IntPtr.Zero);
                }

                // 우클릭
                else if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "마우스 오른쪽 버튼 누름")
                {
                    mouse_event(0x8000 | 0x0008, (int)coord_x, (int)coord_y, 0, IntPtr.Zero);
                }

                else if (Macro_Macrodata.Items[_numofdata].SubItems[1].Text == "마우스 오른쪽 버튼 뗌")
                {
                    mouse_event(0x8000 | 0x0010, (int)coord_x, (int)coord_y, 0, IntPtr.Zero);
                }
            }
        }



        // 닫기. 더 좋게구현할수있나?
        private void Macro_Closemacro_Click(object sender, EventArgs e)
        {


            Dispose();
        }


        // 여기선 입력받는걸 바로 아래 리스트로 옴겨야됨.
        private void Macro_InputFromSystem_Click(object sender, EventArgs e)
        {
            if (Macro_Macrodata.Items.Count != 0)
            {
                MessageBox.Show("저장된것을 지우고 다시 시도해주세요.");
                return;
            }

            Enabled_false();

            int play_count = -1;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            EventHandler<KeyInputEventArgs> _KeyboardLambda = null;
            EventHandler<EventHook.MouseEventArgs> _MouseLambda = null;
            KeyboardWatcher.Start();
            KeyboardWatcher.OnKeyInput += _KeyboardLambda = (s, ke) =>
            {
                // 멈춤 설정
                if (ke.KeyData.Keyname == "Pause")
                {
                    KeyboardWatcher.OnKeyInput -= _KeyboardLambda;
                    MouseWatcher.OnMouseInput -= _MouseLambda;
                    KeyboardWatcher.Stop();
                    MouseWatcher.Stop();
                    sw.Stop();
                    Enabled_true();

                    return;
                }

                // 여기는 이벤트타입이 이벤트라는 enum이라 0또는 1일때의 텍스트로 바꿈
                string _event_type;
                if (ke.KeyData.EventType == 0)
                    _event_type = "키보드 누름";
                else
                    _event_type = "키보드 뗌";

                String[] _rowdata = { sw.ElapsedMilliseconds.ToString(), _event_type, "" + ke.KeyData._Key };
                ListViewItem _row = new ListViewItem(_rowdata);

                Macro_Macrodata.Items.Add(_row);

                play_count++;
            };

            MouseWatcher.Start();
            MouseWatcher.OnMouseInput += _MouseLambda = (s, ke) =>
            {

                if (Macro_Macrodata.Items.Count == 0 || ke.Message.ToString() != "WM_MOUSEMOVE")
                {
                    string _message = "";
                    if (ke.Message.ToString() == "WM_MOUSEMOVE")
                        _message = "마우스 이동";
                    else if (ke.Message.ToString() == "WM_LBUTTONDOWN")
                        _message = "마우스 왼쪽 버튼 누름";
                    else if (ke.Message.ToString() == "WM_LBUTTONUP")
                        _message = "마우스 왼쪽 버튼 뗌";
                    else if (ke.Message.ToString() == "WM_RBUTTONDOWN")
                        _message = "마우스 오른쪽 버튼 누름";
                    else if (ke.Message.ToString() == "WM_RBUTTONUP")
                        _message = "마우스 오른쪽 버튼 뗌";

                    // 마우스 위치값 더해서 문자열로
                    string _point = ke.Point.x + " " + ke.Point.y;

                    String[] _rowdata = { sw.ElapsedMilliseconds.ToString(), _message, _point };
                    ListViewItem _row = new ListViewItem(_rowdata);

                    Macro_Macrodata.Items.Add(_row);

                    play_count++;


                }
                else if (sw.ElapsedMilliseconds - Int32.Parse(Macro_Macrodata.Items[play_count].SubItems[0].Text) > 50)
                {

                    string _message = "";
                    if (ke.Message.ToString() == "WM_MOUSEMOVE")
                        _message = "마우스 이동";
                    else if (ke.Message.ToString() == "WM_LBUTTONDOWN")
                        _message = "마우스 왼쪽 버튼 누름";
                    else if (ke.Message.ToString() == "WM_LBUTTONUP")
                        _message = "마우스 왼쪽 버튼 뗌";
                    else if (ke.Message.ToString() == "WM_RBUTTONDOWN")
                        _message = "마우스 오른쪽 버튼 누름";
                    else if (ke.Message.ToString() == "WM_RBUTTONUP")
                        _message = "마우스 오른쪽 버튼 뗌";

                    // 마우스 위치값 더해서 문자열로
                    string _point = ke.Point.x + " " + ke.Point.y;

                    String[] _rowdata = { sw.ElapsedMilliseconds.ToString(), _message, _point };
                    ListViewItem _row = new ListViewItem(_rowdata);

                    Macro_Macrodata.Items.Add(_row);

                    play_count++;
                }
            };

        }


        private void Enabled_false()
        {
            this.Macro_InputFromSystem.Enabled = false;
            this.Macro_Editmacro.Enabled = false;
            this.Macro_Addmacro.Enabled = false;
            this.Macro_Closemacro.Enabled = false;
            this.Macro_Deletemacro.Enabled = false;
            this.Macro_Playmacro.Enabled = false;
            this.Macro_Functionmacro.Enabled = false;
            this.Macro_btnDeleteData.Enabled = false;
        }

        private void Enabled_true()
        {
            this.Macro_InputFromSystem.Enabled = true;
            this.Macro_Editmacro.Enabled = true;
            this.Macro_Addmacro.Enabled = true;
            this.Macro_Closemacro.Enabled = true;
            this.Macro_Deletemacro.Enabled = true;
            this.Macro_Playmacro.Enabled = true;
            this.Macro_Functionmacro.Enabled = true;
            this.Macro_btnDeleteData.Enabled = true;
        }


        // 데이터
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Macro_btnDeleteData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("데이터가 모두 삭제됩니다.\r계속 하시겠습니까?", "데이터 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (ListViewItem lv in Macro_Macrodata.Items)
                {
                    Macro_Macrodata.Items.Remove(lv);
                }
            }
        }
    }
}
