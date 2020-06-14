using System;
using System.ComponentModel;

namespace RoboApp.Models
{
     
    public class RoboControl : INotifyPropertyChanged
    {


        private int motorType;
        public int MotorType
        {
            get { return motorType; }
            set
            {
                motorType = value;
                OnPropertyChanged("MotorType");
            }
        }

        private bool istrue;
        public bool Istrue
        {
            get { return istrue; }
            set
            {
                istrue = value;
                OnPropertyChanged("Istrue");
            }
        }
        private string zero_degree;
        public string Zero_Degree
        {
            get { return zero_degree; }
            set
            {
                zero_degree = value;
                OnPropertyChanged("Zero_Degree");
            }
        }
        private string current_degree;
        public string Current_Degree
        {
            get { return current_degree; }
            set
            {
                current_degree = value;
                OnPropertyChanged("Current_Degree");
            }
        }
        private DateTime datatime;
        public DateTime Datatime
        {
            get { return datatime; }
            set
            {
                datatime = value;
                OnPropertyChanged("Datatime");
            }
        }
        private string forward;
        public string Forward
        {
            get { return forward; }
            set
            {
                forward = value;
                OnPropertyChanged("Forward");
            }
        }
        private string back;
        public string Back
        {
            get { return back; }
            set
            {
                back = value;
                OnPropertyChanged("Back");
            }
        }
        private string center;
        public string Center
        {
            get { return center; }
            set
            {
                center = value;
                OnPropertyChanged("Center");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    
    //public class ControlAttributes : INotifyPropertyChanged
    //{

    //    public event PropertyChangedEventHandler PropertyChanged;
    //    protected virtual void OnPropertyChanged(string propertyName)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}

}

   
