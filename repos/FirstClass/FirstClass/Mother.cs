using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mother
{
    private string name;

    /*Mother class' costructor*/
    public Mother(string name)
    {
        this.name = name;
    }

    /*Class Mother property*/
    public string getName
    {
        get
        {
            return name;
        }

    }
}

