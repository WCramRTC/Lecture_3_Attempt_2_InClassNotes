using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_Attempt_2_InClassNotes
{
    internal class Student
    {
        // fields
        private string _name;
        private int _compSciGrade;
        private int _genEdGrade;

        // constructor
        // has to have the same name as the class
        // no return type
        public Student(string name)
        {
            _name = name;
        } // Student

        public Student(string name, int compSciGrade, int genEdGrade)
        {
            _name = name;
            _compSciGrade = compSciGrade;
            _genEdGrade = genEdGrade;
        }

        // properties
        // getter / setter

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        } // Name
        
        // _compSciGrade
        public int CompSciGrade
        {
            get
            {
                return _compSciGrade;
            }
            set
            {
                if(value > 0 && value <= 100 )
                {
                    _compSciGrade = value;
                }
                else
                {
                    throw new Exception("Invalid Amount");
                }
               
            }
        } // CompSciGrade



        // _genEdGrade
        // getters and setters
        public int GenEdGrade
        {
            get
            {
                return _genEdGrade;
            }
            set
            {

                if (value >= 0 && value <= 100)
                {
                    _genEdGrade = value;
                }
               
            }
        } // GenEdGrade


        // methods
        public double Average()
        {
            return (_compSciGrade + _genEdGrade) / 2.0;
        }

    } // class

} // namespace
