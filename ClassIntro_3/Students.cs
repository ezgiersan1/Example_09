namespace ClassIntro_3
{
    internal class Student
    {
        //fields
        private int number;
        private string name;
        private string surname;
        private int point;
        //properties
        //methods
        public void SetNumber(int num)
        { this.number = num; }

        public int GetNumber() 
        { 
            return this.number; 
        }
        public void SetName(string n) 
        { 
            this.name = n; 
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetSurname(string s)
        { 
            this.surname = s; 
        }
        public string GetSurname()
        { 
            return this.surname; 
        }
        public void SetPoint(int p)
        { 
            if (p >= 0 && p <= 100)
            {
                this.point = p;
            }
            else
            {
                this.point = 0;
            }
             
        }
        public int GetPoint()
        { 
            return this.point; 
        }
    }
}
