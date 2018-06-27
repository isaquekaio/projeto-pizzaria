using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    class NFuncionario
    {
        MFuncionario fuc = new MFuncionario();
        List<MFuncionario> l = new List<MFuncionario>();

        public void Insert(MFuncionario f)
        {
            MFuncionario fuc = new MFuncionario();
            List<MFuncionario> l = new List<MFuncionario>();
            if (fuc.Nome == "") throw new ArgumentOutOfRangeException();
            fuc.Insert(f);
        }
    }
}
