using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Class Daughter, a Mother's class extention */
class Daughter : Mother
{
    private string secondName;

    /*Daughter's costructor and the root class' costructor*/
    public Daughter(string name, string secondName) : base(name)
    {
        this.secondName = secondName;
    }

    /*Another kind of property*/
    public string getSecondName
    {
        get => secondName;
    }
}

