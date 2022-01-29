using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakTime
{
    public partial class MyDialog : Form        // Мое диалоговое окно
    {
        BreakTimeForm.State state;              // Состояние, которое будет передано в главную форму, если нажата функциональная кнопка

        // В конструкторе получает 
        // title - заголовок формы, 
        // text - текст в форме, 
        // buttonText - надпись на функциональной кнопке, 
        // returnState - состояние возвращаемое в главную форму при нажатии функциональной кнопки
        public MyDialog(string title, string text, string buttonText, BreakTimeForm.State returnState)
        {
            InitializeComponent();

            this.Text = title;
            label1.Text = text;
            btnFunctional.Text = buttonText;
            state = returnState;
        }

        // Если нажата кнопка отмены, то мы закрываем данное диалоговое окно и передаем управление обратно главной форме
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((BreakTimeForm)this.Owner).logger.Write("Button " + btnCancel + " pressed", Logger.Layers.MyDialog);

            ((BreakTimeForm)this.Owner).logger.Write("MyDialog is closing", Logger.Layers.MyDialog);
            Close();
        }

        // Нажата функциональная кнопка. Передает состояние в главную форму
        private void btnFunctional_Click(object sender, EventArgs e)
        {
            ((BreakTimeForm)this.Owner).logger.Write("Button " + btnFunctional + " pressed", Logger.Layers.MyDialog);

            ((BreakTimeForm)this.Owner).MyDialogResult(state);

            ((BreakTimeForm)this.Owner).logger.Write("MyDialog is closing", Logger.Layers.MyDialog);
            Close();
        }

        // На всякий случай решил освободить ресурсы 
        private void MyDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
