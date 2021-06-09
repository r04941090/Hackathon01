using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 生命靈數
{
    public partial class Form1 : Form
    {
        private List<Data> data;
        private List<Constellation> constellations;
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            data = new List<Data>();
            constellations = new List<Constellation>()
            {
                new Constellation("牧羊座", new Time(3, 21), new Time(4, 30)),
                new Constellation("金牛座", new Time(4, 20), new Time(5, 20)),
                new Constellation("雙子座", new Time(5, 21), new Time(6, 21)),
                new Constellation("巨蟹座", new Time(6, 22), new Time(7, 22)),
                new Constellation("獅子座", new Time(7, 23), new Time(8, 22)),
                new Constellation("處女座", new Time(8, 23), new Time(9, 22)),
                new Constellation("天秤座", new Time(9, 23), new Time(10, 23)),
                new Constellation("天蠍座", new Time(10, 24), new Time(11, 22)),
                new Constellation("射手座", new Time(11, 23), new Time(12, 21)),
                new Constellation("魔羯座", new Time(12, 22), new Time(1, 19)),
                new Constellation("水瓶座", new Time(1, 20), new Time(2, 18)),
                new Constellation("雙魚座", new Time(2, 19), new Time(3, 20))
            };
            ReadText();
        }
        private void ReadText()
        {
            string fileName = @"C:\Users\ASUS\OneDrive - Smasoft Technology\桌面\C#\Hackathon01\生命靈數.txt";
            var FileContent = File.ReadAllLines(fileName).Where((x) => x != String.Empty).Select((x) => x.Trim()).ToList();
            for (int i = 0; i < 11; i++)
            {
                var GetDataRange = FileContent.GetRange(i * 10, 10);
                data.Add(new Data() { Name = GetDataRange[0], Content = GetDataRange.Skip(1).Select((x) => x).ToList() });
            }
        }
        private int GetSoulNumber()
        {
            int TotalNumber = dateTimePicker1.Value.Year + dateTimePicker1.Value.Month + dateTimePicker1.Value.Day;
            return AddNumber(TotalNumber);
        }
        private int AddNumber(int i)
        {
            if(i / 10 == 0)
            {
                return i;
            }
            else
            {
                // int -> string[]
                int result = Array.ConvertAll(i.ToString().ToCharArray().Select((x) => x.ToString()).ToArray(), (x) => int.Parse(x)).Sum();
                return AddNumber(result);
                //int result = 0;
                //var s = i.ToString().ToCharArray();
                //foreach (var item in s)
                //{
                //    result += int.Parse(item.ToString());
                //}

            }
        }
        private string GetStar()
        {
            string star;
            var SelectDay = dateTimePicker1.Value.Ticks;
            return star = constellations.Where((x) => SelectDay >= (new DateTime(dateTimePicker1.Value.Year, x.StartTime.Month, x.StartTime.Day)).Ticks &&
                                                      SelectDay <= (new DateTime(dateTimePicker1.Value.Year, x.EndTime.Month, x.EndTime.Day)).Ticks)
                                        .Select((x) => x.Name).ToList()[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var ContentList = data.Where((x) => x.Name.Contains(GetStar())).Select((x) => x.Content).ToList()[0];
            label3.Text = $"你的星座是：{GetStar()}{Environment.NewLine}{(ContentList[GetSoulNumber() - 1])}";
        }
        



        //if (a >= (new DateTime(dateTimePicker1.Value.Year, 3, 21)).Ticks && a <= (new DateTime(dateTimePicker1.Value.Year, 4, 19)).Ticks)
        //{
        //    star = "牡羊座";
        //}
        //else if(a >= (new DateTime(dateTimePicker1.Value.Year, 4, 20)).Ticks && a <= (new DateTime(dateTimePicker1.Value.Year, 5, 20)).Ticks)
        //{
        //    star = "金牛座";
        //}
        //else if (a >= (new DateTime(dateTimePicker1.Value.Year, 5, 21)).Ticks && a <= (new DateTime(dateTimePicker1.Value.Year, 6, 21)).Ticks)
        //{
        //    star = "雙子座";
        //}
        //else if (a >= (new DateTime(dateTimePicker1.Value.Year, 6, 22)).Ticks && a <= (new DateTime(dateTimePicker1.Value.Year, 7, 22)).Ticks)
        //{
        //    star = "巨蟹座";
        //}
        //else if (a >= (new DateTime(dateTimePicker1.Value.Year, 7, 23)).Ticks && a <= (new DateTime(dateTimePicker1.Value.Year, 8, 22)).Ticks)
        //{
        //    star = "獅子座";
        //}
        //else if (a >= (new DateTime(dateTimePicker1.Value.Year, 8, 23)).Ticks && a <= (new DateTime(dateTimePicker1.Value.Year, 9, 22)).Ticks)
        //{
        //    star = "處女座";
        //}
        //else if (a >= (new DateTime(dateTimePicker1.Value.Year, 9, 23)).Ticks && a <= (new DateTime(dateTimePicker1.Value.Year, 10, 23)).Ticks)
        //{
        //    star = "天秤座";
        //}
        //else if (a >= (new DateTime(dateTimePicker1.Value.Year, 10, 24)).Ticks && a <= (new DateTime(dateTimePicker1.Value.Year, 11, 22)).Ticks)
        //{
        //    star = "天蠍座";
        //}
        //else if (a >= (new DateTime(dateTimePicker1.Value.Year, 11, 23)).Ticks && a <= (new DateTime(dateTimePicker1.Value.Year, 12, 21)).Ticks)
        //{
        //    star = "射手座";
        //}
        //else if (a >= (new DateTime(dateTimePicker1.Value.Year, 12, 22)).Ticks && a <= (new DateTime(dateTimePicker1.Value.Year, 1, 19)).Ticks)
        //{
        //    star = "魔羯座";
        //}
        //else if (a >= (new DateTime(dateTimePicker1.Value.Year, 1, 20)).Ticks && a <= (new DateTime(dateTimePicker1.Value.Year, 2, 18)).Ticks)
        //{
        //    star = "水瓶座";
        //}
        //else
        //{
        //    star = "雙魚座";
        //}
    }
}
