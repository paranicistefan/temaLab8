using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK_winforms_z02
{
    class SecondLight
    {
        private float[] valuesDiffuse = new float[4];
        private float[] valuesPosition = new float[4];

        public SecondLight()
        {
            valuesDiffuse[0] = (float)242/100;
            valuesDiffuse[1] = (float)139 / 100;
            valuesDiffuse[2] = (float)28 / 100;
            valuesPosition[0] = 50f;
            valuesPosition[1] = 50f;
            valuesPosition[2] = 50f;
            valuesPosition[3] = 1f;
        }

        public void decrementX()
        {
            if (valuesPosition[0] > -50)
            {
                valuesPosition[0]--;
            }
        }

        public void decrementY()
        {
            if (valuesPosition[1] > -50)
            {
                valuesPosition[1]--;
            }
        }

        public void decrementZ()
        {
            if (valuesPosition[2] > -50)
            {
                valuesPosition[2]--;
            }
        }

        public float[] getColors() => valuesDiffuse;

        public float[] getPositions() => valuesPosition;

        public void incrementX()
        {
            if (valuesPosition[0] < 50)
            {
                valuesPosition[0]++;
            }
        }

        public void incrementY()
        {
            if (valuesPosition[1] < 50)
            {
                valuesPosition[1]++;
            }
        }

        public void incrementZ()
        {
            if (valuesPosition[2] < 50)
            {
                valuesPosition[2]++;
            }
        }
    }

}
