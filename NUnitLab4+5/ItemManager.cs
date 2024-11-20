using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitLab4_5
{

    public class ItemManager
    {
        private List<Items> items = new List<Items>();
        public void AddItems(Items item)
        {
            if (string.IsNullOrWhiteSpace(item.Name) || item.Name.Length >= 50 || !item.Name.All(char.IsLetter))
                throw new ArgumentException("Name must be alphabetic and under 50 word");
            items.Add(item);
        }

        public void UpdateItems(int id, string Newname)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                if (string.IsNullOrWhiteSpace(Newname) || Newname.Length >= 50 || !Newname.All(char.IsLetter))
                    throw new ArgumentException("Name must be alphabetic and under 50 word");
                item.Name = Newname;
            }
            else
            {
                throw new ArgumentException("Id 404 not found");
            }
        }
        public void DeleteItems(int id)
        {
            items.RemoveAll(i => i.Id == id);
        }
    }
}
