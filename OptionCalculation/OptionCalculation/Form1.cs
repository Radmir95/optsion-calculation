using System;
using System.Windows.Forms;
using OptionCalculation.Core;
using System.Drawing;
using System.Collections.Generic;

namespace OptionCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Functions func = null;

        double sharesCost;
        double bondsCost;

        double gammaval = 0;
        double bettaval = 0;

        int j = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SetCNText(double value)
        {
            cn.Text = "CN = " + value;
        }

        private void SetFuncPayText(double value)
        {
            funcPay.Visible = true;
            funcPay.Text = "Функция выплаты = " + value;
        }

        private void SetStepText(int value)
        {
            step.Text = "Шаг = " + value;
        }

        private void SetGammaText(double value)
        {
            gamma.Text = "gamma* = " + value;
        }

        private void SetBettaText(double value)
        {
            betta.Text = "betta* = " + value;
        }



        private void SetCostButtonsEnabled()
        {
            btn_up.Enabled = true;
            btn_down.Enabled = true;
        }

        private void SetCostButtonsUnenabled()
        {
            btn_up.Enabled = false;
            btn_down.Enabled = false;
        }

        private void CalcValues(object sender, EventArgs e)
        {
            j++;



            var clickedButton = (Button)sender;


            if (clickedButton.Name == "btn_step0")
            {
                SetCostButtonsEnabled();
                btn_step0.Enabled = false;


                double bo = double.Parse(tbb0.Text);
                double so = double.Parse(tbso.Text);
                int n = int.Parse(tbn.Text);
                double k = double.Parse(tbk.Text);
                double r = double.Parse(tbr.Text);
                double at = double.Parse(tba.Text);
                double b = double.Parse(tbb.Text);

                tbb0.Enabled = false;
                tbso.Enabled = false;
                tbn.Enabled = false;
                tbk.Enabled = false;
                tbr.Enabled = false;
                tba.Enabled = false;
                tbb.Enabled = false;

                var sc = new StartConditions(so, bo, n, r, at, b, k);

                func = new Functions(sc);

                double Cn = func.FindCN();


                SetCNText(Cn);

                sharesCost = func.GetPrevSharesCost();
                bondsCost = func.GetPrevBondsCost();


                SetStepText(j - 1);

                double x = func.FindCN();

                gammaval = func.FindGamma(j, sharesCost);
                bettaval = func.FindBetta(x, gammaval, sharesCost, bondsCost);

                if (gammaval == 0 && bettaval == 0)
                {
                    errortext.Visible = true;
                    //break;
                }

                SetGammaText(gammaval);
                SetBettaText(bettaval);

            }

            else if ((j - 1) != func.sc.N)
            {

                SetStepText(j - 1);

                double newSharesCost = 0;
                double newBondsCost = 0;

                switch (clickedButton.Name)
                {
                    case "btn_up":
                        newSharesCost = func.GetIncreasedSharesCost(sharesCost, func.sc.b);
                        newBondsCost = func.GetIncreasedBondsCost(bondsCost, func.sc.b);
                        break;
                    case "btn_down":
                        newSharesCost = func.GetLoweredSharesCost(sharesCost, func.sc.a);
                        newBondsCost = func.GetLoweredBondsCost(bondsCost, func.sc.a);
                        break;
                }

                double x = func.FindCN();

                double gamma = func.FindGamma(j, newSharesCost);
                double betta = func.FindBetta(x, gammaval, newSharesCost, newBondsCost);

                sharesCost = newSharesCost;
                bondsCost = newBondsCost;

                if (gamma != 0 && betta != 0)
                {
                    gammaval = gamma;
                    bettaval = betta;

                    SetGammaText(gammaval);
                    SetBettaText(bettaval);
                }
                else
                {
                    GiveMoneyBack();
                }
            }
            else if ((j - 1) == func.sc.N)
            {

                HideValuesForLastStep();

                SetStepText(j - 1);
                endtime.Visible = true;
                SetCostButtonsUnenabled();

                double newSharesCost = 0;

                switch (clickedButton.Name)
                {
                    case "btn_up":

                        newSharesCost = func.GetIncreasedSharesCost(sharesCost, func.sc.b);

                        if (Math.Max(0, newSharesCost - func.sc.K) != 0)
                        {
                            double funcPay = Math.Max(0, newSharesCost - func.sc.K);
                            SetFuncPayText(funcPay);
                        }
                        else
                        {
                            GiveMoneyBack();
                        }
                        break;
                    case "btn_down":
                        newSharesCost = func.GetLoweredSharesCost(sharesCost, func.sc.a);

                        if (Math.Max(0, newSharesCost - func.sc.K) != 0)
                        {
                            double funcPay = Math.Max(0, newSharesCost - func.sc.K);
                            SetFuncPayText(funcPay);
                        }
                        else
                        {
                            GiveMoneyBack();
                        }
                        break;
                }

            }
        }

        private void GiveMoneyBack()
        {

            errortext.Visible = true;
            SetCostButtonsUnenabled();

            bankb.Visible = true;

            var s = func.sc.B0;

            for (int i = 0; i < (j-1); i++)
            {
                s *= (1 + func.sc.R);
            }

          

        }

        private void HideValuesForLastStep()
        {
            gamma.Visible = false;
            betta.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbso.Text = string.Empty;
            tbb0.Text = string.Empty;
            tbn.Text = string.Empty;
            tbr.Text = string.Empty;
            tba.Text = string.Empty;
            tbb.Text = string.Empty;
            tbk.Text = string.Empty;
        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = panel1.CreateGraphics(); // создаем место для рисования
        //    g.TranslateTransform(3200, 200); // смещение начала координат (в пикселях)
        //    g.RotateTransform(180f);
        //    g.ScaleTransform(7f, 7f);

        //    List<Point> p = new List<Point>(); // список точек графика

        //    Pen pen = new Pen(Color.DarkRed, 0.5f); // перо, для отрисовки графика
        //    Pen gridPen = new Pen(Color.DeepPink, 0.0001f); //перо для отрисовки координатной сетки
        //    Pen penCO = new Pen(Color.Green, 2f);
        //    Font fo = new System.Drawing.Font(FontFamily.GenericSerif, 3f); //шрифт для выведения текстовой информации, в данном случае не используется
        //    g.DrawLine(penCO, new Point(-5000, 0), new Point(5000, 0));
        //    g.DrawLine(penCO, new Point(0, -5000), new Point(0, 5000)); // толстая зеленая линия, ось OX
        //                                                                // рисуем координатную сетку
        //    int x = 0; //начальное значение координаты х. Постороение идет из указанной точки
        //    int y = -100; // начальное значение координаты у. Пояснение см выше.

        //    while (x <= 500) //конечное значение координаты х. Бесконечное количество линий нам не надо, ибо никакой памяти не хватит
        //    {
        //        x = x + 5; // шаг линий, параллельных оси ОУ
        //        y = y + 5; //шаг линий, параллельных оси ОХ
        //        g.DrawLine(gridPen, new Point(x, -500), new Point(x, 1000)); // рисуем линии, параллельные оси ОУ
        //        g.DrawLine(gridPen, new Point(-500, y), new Point(1000, y)); //рисуем линии, параллельные оси ОХ

        //    }
        //    double E = 415;  //начальная точка графика
        //    while (E <= 435) // цикл для создания списка точек, расчет идет до указанного значения, которое является конечной точкой графика
        //    {
        //        E = E + 0.85; // шаг расчета координаты х
        //        double R = (1 / (0.4 * 0.00000075 * Math.Pow(E, 0.81))); //часть расчета координаты у
        //        double dU = ((15 / 4) * ((R - 24767.6) / 24767.6)); // еще одна часть расчета координаты у
        //        double U = (820000 / 2000) * dU; //   координата у нашего графика
        //        Point poss = new Point((int)E, (int)U); // создаем новую точку с рассчитанными координатами
        //        p.Add(poss); // добавляем точку в список точек

        //    }
        //    g.DrawCurve(pen, p.ToArray()); // отрисовка графика. Так так метод DrawCurwe() не может считывать данные из листа, а только из массива, то создаем из листа массив, по данным которого и идет постороение графика
        //}


    }
}
//moneyback.Text = "Денег у нас сейчас: " + gammaval.ToString() + " * " + sharesCost + " = " + gammaval * sharesCost + '\n' +
//    "Необходимо вернуть: " + (-bettaval) + " * " + s + " = " + (-bettaval)*s;


//moneyback.Visible = true;