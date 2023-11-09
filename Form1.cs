using System;
using System.Windows.Forms;

namespace ModulControl {
    public partial class Form1 : Form {
        private AbstractArray arr = new AbstractArray();
        private InfoShow show = new InfoShow();

        public Form1() {
            InitializeComponent();
        }

        private double Ran() {
            var random = new Random();
            var randomDouble = random.NextDouble() * (15 - 5) + 5;
            return Math.Round(randomDouble, 1);
        }

        private void GenerateArray(int num) {
            for (var i = 0; i < num; i++) {
                var pentagon = new Pentagon(Ran(), Ran());
                arr.AddFigure(pentagon);
                
                var pentagon_pyr = new Pentagon_Pyramid(Ran(), Ran(), Ran(), Ran());
                arr.AddFigure(pentagon_pyr);

                var rec = new Ractangle(Ran(), Ran());
                arr.AddFigure(rec);

                var rec_P = new Rectangular_Prism(Ran(), Ran());
                arr.AddFigure(rec_P);

                var rh = new Rhombus(Ran(), Ran());
                arr.AddFigure(rh);

                var sp = new Sphere(Ran());
                arr.AddFigure(sp);

                var co = new Cone(Ran(), Ran());
                arr.AddFigure(co);
            }
        }

        private void ShowList() {
            dataGrid.Rows.Clear();
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var fig in arr) {
                dataGrid.Rows.Add(show.GetInfo(fig));
            }
        }
        
        private void generate_Click(object sender, EventArgs e) {
            try {
                var num = Convert.ToInt32(this.numElem.Text);
                GenerateArray(num);
                ShowList();
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}