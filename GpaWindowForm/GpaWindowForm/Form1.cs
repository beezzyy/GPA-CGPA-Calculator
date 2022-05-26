namespace GpaWindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            totalG = 0;
            totalC = 0;
            gpa = 0;
            printTotalGPA = 0;
            letterGrade();

        }
             float totalG =0; 
             double totalC = 0;
             float gpa = 0;
             float printTotalGPA = 0f;
        public void letterGrade()
        {
           double c1=0,c2=0,c3=0,c4=0,c5=0;
           string lg1=null,lg2=null,lg3=null,lg4=null,lg5=null;
           
          
           
           float _printTotalGPA = 0f;

            if (!(crdt1.Text.Equals("")))
                c1 = Convert.ToDouble(crdt1.Text);
            if (!(crdt2.Text.Equals("")))
                c2 = Convert.ToDouble(crdt2.Text);
            if (!(crdt3.Text.Equals("")))
                c3 = Convert.ToDouble(crdt3.Text);
            if (!(crdt4.Text.Equals("")))
                c4 = Convert.ToDouble(crdt4.Text);
            if (!(crdt5.Text.Equals("")))
                c5 = Convert.ToDouble(crdt5.Text);

            if (!(letterg1.Text.Equals("")))
                lg1 = letterg1.Text.ToUpper();
            if (!(letterg2.Text.Equals("")))
                lg2 = letterg2.Text.ToUpper();
            if (!(letterg3.Text.Equals("")))
                lg3 = letterg3.Text.ToUpper();
            if (!(letterg4.Text.Equals("")))
                lg4 = letterg4.Text.ToUpper();
            if (!(letterg5.Text.Equals("")))
                lg5 = letterg5.Text.ToUpper();

            totalC = c1 + c2 + c3 + c4+ c5;

            if (lg1 != null)
            {
                switch (lg1)
                {
                    case "A+":
                        gpa = (float)(c1 * 4.3);
                        break;
                    case "A":
                        gpa = (float)(c1 * 4.0);
                        break;
                    case "A-":
                        gpa = (float)(c1 * 3.7);
                        break;
                    case "B+":
                        gpa = (float)(c1 * 3.3);
                        break;
                    case "B":
                        gpa = (float)(c1 * 3.0);
                        break;
                    case "B-":
                        gpa = (float)(c1 * 2.7);
                        break;
                    case "C+":
                        gpa = (float)(c1 * 2.3);
                        break;
                    case "C":
                        gpa = (float)(c1 * 2.0);
                        break;
                    case "C-":
                        gpa = (float)(c1 * 1.7);
                        break;
                    case "D+":
                        gpa = (float)(c1 * 1.3);
                        break;
                    case "D":
                        gpa = (float)(c1 * 1.0);
                        break;
                    case "D-":
                        gpa = (float)(c1 * 0.7);
                        break;
                    case "F":
                        gpa = (float)(c1 * 0);
                        break;

                }
            }

            if (lg1 == null)
                gpa = 0;
                    
                    
           totalG = totalG + gpa;

            if (lg2 != null)
            {
                switch (lg2)
                {
                    case "A+":
                        gpa = (float)(c2 * 4.3);
                        break;
                    case "A":
                        gpa = (float)(c2 * 4.0);
                        break;
                    case "A-":
                        gpa = (float)(c2 * 3.7);
                        break;
                    case "B+":
                        gpa = (float)(c2 * 3.3);
                        break;
                    case "B":
                        gpa = (float)(c2 * 3.0);
                        break;
                    case "B-":
                        gpa = (float)(c2 * 2.7);
                        break;
                    case "C+":
                        gpa = (float)(c2 * 2.3);
                        break;
                    case "C":
                        gpa = (float)(c2 * 2.0);
                        break;
                    case "C-":
                        gpa = (float)(c2 * 1.7);
                        break;
                    case "D+":
                        gpa = (float)(c2 * 1.3);
                        break;
                    case "D":
                        gpa = (float)(c2 * 1.0);
                        break;
                    case "D-":
                        gpa = (float)(c2 * 0.7);
                        break;
                    case "F":
                        gpa = (float)(c2 * 0);
                        break;

                }
            }
            if (lg2 == null)
                gpa = 0;

            totalG = totalG + gpa;

            if (lg3 != null)
            {
                switch (lg3)
                {
                    case "A+":
                        gpa = (float)(c3 * 4.3);
                        break;
                    case "A":
                        gpa = (float)(c3 * 4.0);
                        break;
                    case "A-":
                        gpa = (float)(c3 * 3.7);
                        break;
                    case "B+":
                        gpa = (float)(c3 * 3.3);
                        break;
                    case "B":
                        gpa = (float)(c3 * 3.0);
                        break;
                    case "B-":
                        gpa = (float)(c3 * 2.7);
                        break;
                    case "C+":
                        gpa = (float)(c3 * 2.3);
                        break;
                    case "C":
                        gpa = (float)(c3 * 2.0);
                        break;
                    case "C-":
                        gpa = (float)(c3 * 1.7);
                        break;
                    case "D+":
                        gpa = (float)(c3 * 1.3);
                        break;
                    case "D":
                        gpa = (float)(c3 * 1.0);
                        break;
                    case "D-":
                        gpa = (float)(c3 * 0.7);
                        break;
                    case "F":
                        gpa = (float)(c3 * 0);
                        break;

                }
            }
            if(lg3 == null)
                gpa = 0;

            totalG = totalG + gpa;

            if (lg4 != null)
            {
                switch (lg4)
                {
                    case "A+":
                        gpa = (float)(c4 * 4.3);
                        break;
                    case "A":
                        gpa = (float)(c4 * 4.0);
                        break;
                    case "A-":
                        gpa = (float)(c4 * 3.7);
                        break;
                    case "B+":
                        gpa = (float)(c4 * 3.3);
                        break;
                    case "B":
                        gpa = (float)(c4 * 3.0);
                        break;
                    case "B-":
                        gpa = (float)(c4 * 2.7);
                        break;
                    case "C+":
                        gpa = (float)(c4 * 2.3);
                        break;
                    case "C":
                        gpa = (float)(c4 * 2.0);
                        break;
                    case "C-":
                        gpa = (float)(c4 * 1.7);
                        break;
                    case "D+":
                        gpa = (float)(c4 * 1.3);
                        break;
                    case "D":
                        gpa = (float)(c4 * 1.0);
                        break;
                    case "D-":
                        gpa = (float)(c4 * 0.7);
                        break;
                    case "F":
                        gpa = (float)(c4 * 0);
                        break;

                }
            }
            if(lg4 == null)
                gpa = 0;

            totalG = totalG + gpa;

            if (lg5 != null)
            {
                switch (lg5)
                {
                    case "A+":
                        gpa = (float)(c5 * 4.3);
                        break;
                    case "A":
                        gpa = (float)(c5 * 4.0);
                        break;
                    case "A-":
                        gpa = (float)(c5 * 3.7);
                        break;
                    case "B+":
                        gpa = (float)(c5 * 3.3);
                        break;
                    case "B":
                        gpa = (float)(c5 * 3.0);
                        break;
                    case "B-":
                        gpa = (float)(c5 * 2.7);
                        break;
                    case "C+":
                        gpa = (float)(c5 * 2.3);
                        break;
                    case "C":
                        gpa = (float)(c5 * 2.0);
                        break;
                    case "C-":
                        gpa = (float)(c5 * 1.7);
                        break;
                    case "D+":
                        gpa = (float)(c5 * 1.3);
                        break;
                    case "D":
                        gpa = (float)(c5 * 1.0);
                        break;
                    case "D-":
                        gpa = (float)(c5 * 0.7);
                        break;
                    case "F":
                        gpa = (float)(c5 * 0);
                        break;

                }
            }

            if(lg5 == null)
                gpa = 0;
            totalG = totalG + gpa;
            printTotalGPA = (float)(totalG / totalC);
            string toString = printTotalGPA.ToString();
            label4.Text = "GPA";
            if (toString.Length <= 3)
                amountGpa.Text = toString;
            else
            {
                amountGpa.Text = toString.Substring(0, 5);
            }
            

        }

        private void cgpa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Totalg_Click(object sender, EventArgs e)
        {
            float cgpa = 0f;
            double creditTotal = 0.0;
            double multiplyCGPA_CREDIT = 0.0;
            float total_total_G = 0.0f;
            float printCPGA = 0.0f;

            if (!(cgpaNumber.Text.Equals("")))
                 cgpa = Convert.ToSingle(cgpaNumber.Text);
            if (!(numberOfTotalCrdit.Text.Equals("")))
                creditTotal = Convert.ToDouble(numberOfTotalCrdit.Text);
            
            multiplyCGPA_CREDIT = cgpa* creditTotal;
            total_total_G = (float)(multiplyCGPA_CREDIT + totalG);

            printCPGA = (float)(total_total_G / (totalC + creditTotal));

            string s = printCPGA.ToString();
            label7.Text = "CGPA";
            label6.Text = s.Substring(0,5);



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);

        }
    }
}