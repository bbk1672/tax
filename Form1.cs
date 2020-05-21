using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxFull
{
    public partial class Form1 : Form
    {
        double taxgroup1, taxgroup2, taxgroup3, taxgroup4, taxgroup5, yearsal, sumoftax, distax, taxyag,taxyag2;
        
        public Form1()
        {
            InitializeComponent();
        }

       
      

        private void btncalculate_Click(object sender, EventArgs e)
        {
            salary_TextChanged(sender, e);
            savelife(sender, e);
            housepayment_Value(sender, e);
            supportanything_Value(sender, e);
            shopshare_cost(sender, e);
            if (sumoftax >= 0 && sumoftax < 150000)
            {
                sumoftax = 0;
            }
            else if (sumoftax > 150000 && sumoftax <= 300000)
            {
                sumoftax = (sumoftax - 150000) * 0.05;
            }
            else if (sumoftax > 300000 && sumoftax <= 500000)
            {
                sumoftax = (sumoftax - 300000) * 0.1 + 7500;
            }
            else if (sumoftax > 500000 && sumoftax <= 750000)
            {
                sumoftax = (sumoftax - 500000) * 0.15 + 27500;
            }
            else if (sumoftax > 750000 && sumoftax <= 1000000)
            {
                sumoftax = (sumoftax - 750000) * 0.2 + 65000;
            }
            else if (sumoftax > 1000000 && sumoftax <= 2000000)
            {
                sumoftax = (sumoftax - 1000000) * 0.25 + 115000;
            }
            else if (sumoftax > 2000000 && sumoftax <= 5000000)
            {
                sumoftax = (sumoftax - 2000000) * 0.3 + 365000;
            }
            else if (sumoftax > 5000000)
            {
                sumoftax = (sumoftax - 5000000) * 0.35 + 1265000;
            }
            costtax.Text = sumoftax.ToString();
            
        }

        private void housepayment_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            single.Checked = false;
            marry.Checked = false;
            other.Checked = false;
            father.Checked = false;
            mother.Checked = false;
            fathercouple.Checked = false;
            mothercouple.Checked = false;
            nocouple.Checked = false;
            couplemoney.Checked = false;
            couplenomoney.Checked = false;
            costtax.Text = "0";
            salary.Text = "0";
            pregnant.Text = "0";
            pregnant.Value = 0;
            injured.Text = "0";
            injured.Value = 0;
            childbefore2561.Text = "0";
            childbefore2561.Value = 0;
            childafter2561.Text = "0";
            childafter2561.Value = 0;
            social.Text = "0";
            social.Value = 0;
            lifesave.Text = "0";
            lifesave.Value = 0;
            health.Text = "0";
            health.Value = 0;
            momdad.Text = "0";
            momdad.Value = 0;
            couple.Text = "0";
            couple.Value = 0;
            moneylifesave.Text = "0";
            moneylifesave.Value = 0;
            koch.Text = "0";
            koch.Value = 0;
            gbk.Text = "0";
            gbk.Value = 0;
            bumnan.Text = "0";
            bumnan.Value = 0;
            ltf.Text = "0";
            ltf.Value = 0;
            rmf.Text = "0";
            rmf.Value = 0;
            house.Text = "0";
            house.Value = 0;
            housebefore58.Text = "0";
            housebefore58.Value = 0;
            houseafter62.Text = "0";
            houseafter62.Value = 0;
            supportanything.Text = "0";
            supportanything.Value = 0;
            supportnormal.Text = "0";
            supportnormal.Value = 0;
            supportparty.Text = "0";
            supportparty.Value = 0;
            shopshare.Text = "0";
            shopshare.Value = 0;
            sportshare.Text = "0";
            sportshare.Value = 0;
            sut.Text = "0";
            costtax.Text = "0";
            buybook.Text = "0";
            buybook.Value = 0;
            buyotop.Text = "0";
            buyotop.Value = 0;
            metropolistravel.Text = "0";
            metropolistravel.Value = 0;
            normaltravel.Text = "0";
            normaltravel.Value = 0;
            houserepair.Text = "0";
            houserepair.Value = 0;
            carrepair.Text = "0";
            carrepair.Value = 0;
        }

        private void label40_Click(object sender, EventArgs e)
        {

        } 
        // กลุ่มที่ 1
        private void salary_TextChanged(object sender, EventArgs e)
        {
            taxgroup1 = 0;
            //สถานนะ
            if (single.Checked)
            {
                taxgroup1 += 60000;
            }
            else if (marry.Checked)
            {
                if (nocouple.Checked)
                {
                    taxgroup1 += 60000;
                }
                else if (couplemoney.Checked)
                {
                    taxgroup1 += 60000;
                }
                else
                {
                    taxgroup1 += 120000;
                }
            }
            else
            {
                taxgroup1 += 60000;
            }
            // พ่อแม่ตัวเอง
            if (father.Checked)
            {
                taxgroup1 += 30000;
            }
            if (mother.Checked)
            {
                taxgroup1 += 30000;
            }
            else
            {
                taxgroup1 += 0;
            }
            // พ่อแม่คู่สมรส
            if (fathercouple.Checked)
            {
                taxgroup1 += 30000;
            }
            if (mothercouple.Checked)
            {
                taxgroup1 += 30000;
            }
            else
            {
                taxgroup1 += 0;
            }
            // ลูกก่อน 61
            int tempchildafter61;
            int numbericchildafter61 = Convert.ToInt32(childafter2561.Value);
            if (childafter2561.Value > 0)
            {
                if (childbefore2561.Value == 0)
                {
                    tempchildafter61 = ((numbericchildafter61 - 1) * 60000 + 30000);
                }
                else
                {
                    tempchildafter61 = numbericchildafter61 * 60000;
                }
            }
            else
            {
                tempchildafter61 = 0;
            }
            taxgroup1 += tempchildafter61;
            int tempchildbefore61 = Convert.ToInt32(childbefore2561.Value) * 30000;

            //ค่าฝากครรภ์
            int pre = Convert.ToInt32(pregnant.Value);
            if (pregnant.Text == "")
            {
                pregnant.Text = "0";
            }
            //ค่าบาดเจ็บ
            int inj = Convert.ToInt32(injured.Value) * 60000;
            if (injured.Text == "")
            {
                injured.Text = "0";
            }

            //รวมกลุ่มที่ 1
            taxgroup1 = taxgroup1 + inj + pre + tempchildbefore61;

            //แก้บัคไม่ใส่ตัวเลขเงินเดือน
            if (salary.Text == "")
            {
                MessageBox.Show("กรุณากรอกจำนวนเงินเดือน", "Salary Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                salary.Text = "0";
            }
            //รวมรายได้ต่อปี
            yearsal = Convert.ToDouble(salary.Text) * 12;

            double yeardata = yearsal * 0.5;
            if (yeardata > 100000)
            {
                taxgroup1 = taxgroup1 + 100000;
            }
            yearsalary.Text = yearsal.ToString();
          
            if (sumoftax < 0)
            {
                sumoftax = 0;
            }
            distax = taxgroup1 + taxgroup2 + taxgroup3 + taxgroup5;
            sumoftax = (yearsal -  distax) - taxgroup4;
            sut.Text = sumoftax.ToString();
        }

        // กลุ่มที่ 2
        private void savelife(object sender, EventArgs e)
        {
            taxgroup2 = 0;
            //15%
            double discount15 = yearsal * 0.15;
            //ประกันสังคม
            int social_pragun = Convert.ToInt32(social.Value);
            if (social_pragun >= 9000)
            {
                social_pragun = 9000;
            }
            if (social.Text == "")
            {
                social.Text = "0";
            }

            // ประกันชีวิต
            int life_pragun = Convert.ToInt32(lifesave.Value);
            if (life_pragun >= 100000)
            {
                life_pragun = 100000;
            }
            if (lifesave.Text == "")
            {
                lifesave.Text = "0";
            }

            // ประกันสุขภาพ
            int body_pragun = Convert.ToInt32(health.Value);
            if (body_pragun >= 15000)
            {
                body_pragun = 15000;
            }
            if (health.Text == "")
            {
                health.Text = "0";
            }
            int pragunsum = life_pragun + body_pragun;

            // รวมประกันสุขภาพ + ประกันชีวิต
            if (pragunsum >= 100000)
            {
                pragunsum = 100000;
            }

            // เบี้ยสุขภาพบิดามารดา
            int dadsummom = Convert.ToInt32(momdad.Value);
            if (dadsummom >= 15000)
            {
                dadsummom = 15000;
            }
            if (momdad.Text == "")
            {
                momdad.Text = "0";
            }

            // คู่สมรส
            int couplesum = Convert.ToInt32(couple.Value);
            if (couplesum >= 10000)
            {
                couplesum = 10000;
            }
            if (couple.Text == "")
            {
                couple.Text = "0";
            }

            // เงินกองทุนสำรองเลี้ยงชีพ
            int spare = Convert.ToInt32(moneylifesave.Value);
            if (moneylifesave.Text == "")
            {
                moneylifesave.Text = "0";
            }
            if (discount15 > 490000 && spare > 10000)
            {
                moneylifesave.Maximum = 500000;
            }
            else if (discount15 < 490000 && spare > discount15)
            {
                moneylifesave.Maximum = Convert.ToInt32(discount15);
            }
            else if (discount15 > 490000 && spare < discount15)
            {
                moneylifesave.Maximum = 490000;
            }
            else
            {
                moneylifesave.Maximum = 500000;
            }

            // เบี้ยเงินสะสมกองทุน
            int stack = Convert.ToInt32(gbk.Value);
            if (gbk.Text == "")
            {
                gbk.Text = "0";
            }
            if (discount15 > 500000)
            {
                gbk.Maximum = 500000;
            }
            else
            {
                gbk.Maximum = Convert.ToInt32(discount15);
            }

            // เงินสะสม กอช.
            int stackthai = Convert.ToInt32(koch.Value);

            // เงินบำนาญ
            int moneypermanent = Convert.ToInt32(bumnan.Value);
            if (bumnan.Text == "")
            {
                bumnan.Text = "0";
            }
            if (discount15 > 200000)
            {
                bumnan.Maximum = 200000;
            }
            else
            {
                bumnan.Maximum = Convert.ToInt32(discount15);
            }
            // LTF
            int ltfbuy = Convert.ToInt32(ltf.Value);
            if (ltf.Text == "")
            {
                ltf.Text = "0";
            }
            if (discount15 > 500000)
            {
                ltf.Maximum = 500000;
            }
            else
            {
                ltf.Maximum = Convert.ToInt32(discount15);
            }
            // RMF
            int rmfbuy = Convert.ToInt32(rmf.Value);
            if (rmf.Text == "")
            {
                rmf.Text = "0";
            }
            if (discount15 > 500000)
            {
                rmf.Maximum = 500000;
            }
            else
            {
                rmf.Maximum = Convert.ToInt32(discount15);
            }
            // รวม
            int sumstackmoney = moneypermanent + spare + stack + rmfbuy;
            if (sumstackmoney > 500000)
            {
                sumstackmoney = 500000;
            }
            else
            {
                sumstackmoney = moneypermanent + spare + stack + rmfbuy;
            }

            taxgroup2 = sumstackmoney + social_pragun + pragunsum + ltfbuy + couplesum + dadsummom + stackthai;
        }
        // กลุ่มที่ 3
        private void housepayment_Value(object sender, EventArgs e)
        {
            taxgroup3 = 0;
            int housepaid = Convert.ToInt32(house.Value);
            if (house.Text == "")
            {
                house.Text = "0";
            }
            double firsthouse58 = (Convert.ToInt32(housebefore58.Value)) * 0.04;
            if (housebefore58.Text == "")
            {
                housebefore58.Text = "0";
            }
            double firsthouse62 = (Convert.ToInt32(houseafter62.Value)) * 0.04;
            if (houseafter62.Text == "")
            {
                houseafter62.Text = "0";
            }
            taxgroup3 = housepaid + firsthouse58 + firsthouse62;
        }
        // กลุ่มที่ 4
        private void supportanything_Value(object sender, EventArgs e)
        {
            taxgroup4 = 0;
            taxyag = yearsal - distax;
            double taxza = taxyag * 0.1;
            double sharemoney = Convert.ToInt32(supportanything.Value) * 2;
            if (sharemoney > taxza)
                {
                sharemoney = taxza;
                }
            if (supportanything.Text == "")
            {
                supportanything.Text = "0";
            }
            double sharemoneynormal = Convert.ToInt32(supportnormal.Value);
            taxyag2 = yearsal  - distax - sharemoney;
            double sup10peradvanced = taxyag2 * 0.1;
            if (sharemoneynormal > sup10peradvanced)
            {
                sharemoneynormal = sup10peradvanced;
            }
            if (supportnormal.Text == "")
            {
                supportnormal.Text = "0";
            }
            double sharemoneytoparty = Convert.ToInt32(supportparty.Value);
            if (supportparty.Text == "")
            {
                supportparty.Text = "0";
            }

            // บริจาคต่างๆ
            
            
            
            // บริจาคเงินทั่วไป + บริจาครัฐบาล
            taxgroup4 = sharemoney + sharemoneynormal+sharemoneytoparty;
        }
        // กลุ่มที่ 5
        private void shopshare_cost(object sender, EventArgs e)
        {
            taxgroup5 = 0;

            // ช๊อปช่วยชาติ
            int nationhelp = Convert.ToInt32(shopshare.Value);
            if (nationhelp > 15000)
            {
                nationhelp = 15000;
            }
            if (shopshare.Text == "")
            {
                shopshare.Text = "0";
            }

            // การกีฬา
            int sporthelp = Convert.ToInt32(sportshare.Value);
            if (sporthelp > 15000)
            {
                sporthelp = 15000;
            }
            if (sportshare.Text == "")
            {
                sportshare.Text = "0";
            }

            // หนังสือ
            int bookhelp = Convert.ToInt32(buybook.Value);
            if (bookhelp > 15000)
            {
                bookhelp = 15000;
            }
            if (buybook.Text == "")
            {
                buybook.Text = "0";
            }

            // โอท็อป
            int otophelp = Convert.ToInt32(buyotop.Value);
            if (otophelp > 15000)
            {
                otophelp = 15000;
            }
            if (buyotop.Text == "")
            {
                buyotop.Text = "0";
            }

            // เมืองหลวง
            int mtravel = Convert.ToInt32(metropolistravel.Value);
            if (mtravel > 15000)
            {
                mtravel = 15000;
            }
            if (metropolistravel.Text == "")
            {
                metropolistravel.Text = "0";
            }

            // เมืองรอง
            int ntravel = Convert.ToInt32(normaltravel.Value);
            if (ntravel > 20000)
            {
                ntravel = 20000;
            }
            if (normaltravel.Text == "")
            {
                normaltravel.Text = "0";
            }

            // รวมเมืองหลวง+รอง
            int sumtravel = mtravel + ntravel;
            if (sumtravel > 20000)
            {
                sumtravel = 20000;
            }

            // บ้าน
            int house = Convert.ToInt32(houserepair.Value);
            if (house > 100000)
            {
                house = 100000;
            }
            if (houserepair.Text == "")
            {
                houserepair.Text = "0";
            }

            // รถ
            int car = Convert.ToInt32(carrepair.Value);
            if (car > 30000)
            {
                car = 30000;
            }
            if (carrepair.Text == "")
            {
                carrepair.Text = "0";
            }

            // รวมบ้าน+รถ
            int sumbanrod = house + car;
            if (sumbanrod > 100000)
            {
                sumbanrod = 100000;
            }
            taxgroup5 = nationhelp + sporthelp + bookhelp + otophelp + sumtravel + sumbanrod;
        }
    }
}
