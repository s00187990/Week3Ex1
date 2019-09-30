using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Ex1
{
    public class Car
    {
        public string Make
        {
            get { return this.Make; }
            set { this.Make = value; }
        }

        private string _model;

        public string Model
        {
            get { return this._model; }
            set { this.Model = value; }
        }

        private int currentSpeed;

        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }

        private double engineSize;

        public double EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }
    }
}
