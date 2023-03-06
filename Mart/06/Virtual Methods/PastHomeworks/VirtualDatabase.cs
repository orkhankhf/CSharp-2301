using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomeworks
{
    public static class VirtualDatabase
    {
        private static ArrayList _db = new ArrayList();

        public static bool IsBarcodeDuplicate(string barcode, int? exceptId = null)
        {
            if (_db != null && _db.Count > 0)
            {
                for (int i = 0; i < _db.Count; i++)
                {
                    Item item = (Item)_db[i];
                    if (item.Barcode == barcode && !item.IsDeleted && item.Id != exceptId)
                        return true;
                }
            }
            return false;
        }

        public static void NewItem(Item newItem)
        {
            if(newItem != null && !string.IsNullOrEmpty(newItem.Barcode))
            {
                newItem.CreateDate = DateTime.Now;
                newItem.CreateUser = 100;
                _db.Add(newItem);
            }
        }

        public static void NewItems(params Item[] items)
        {
            if (items != null)
            {
                foreach (var item in items)
                {
                    if (!string.IsNullOrEmpty(item.Barcode))
                    {
                        if(IsBarcodeDuplicate(item.Barcode))
                            Console.WriteLine("Bu barkod daha once basqa mehsul ucun sisteme elave olunub!");
                        else
                        {
                            item.CreateDate = DateTime.Now;
                            item.CreateUser = 100;
                            _db.Add(item);
                        }
                    }
                }
            }
        }

        public static void UpdateItem(Item updateItem)
        {
            if (updateItem != null && !string.IsNullOrEmpty(updateItem.Barcode))
            {
                if (_db != null && _db.Count > 0)
                {
                    for (int i = 0; i < _db.Count; i++)
                    {
                        BaseClass item = (BaseClass)_db[i];
                        if(item.Id == updateItem.Id)
                        {
                            if(!IsBarcodeDuplicate(updateItem.Barcode, item.Id))
                            {
                                updateItem.EditDate = DateTime.Now;
                                updateItem.EditUser = 101;
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void DeleteItem(Item deleteItem)
        {
            if(deleteItem != null)
            {
                if (_db != null && _db.Count > 0)
                {
                    for (int i = 0; i < _db.Count; i++)
                    {
                        BaseClass item = (BaseClass)_db[i];
                        if (item.Id == deleteItem.Id)
                        {
                            deleteItem.DeleteDate = DateTime.Now;
                            deleteItem.DeleteUser = 102;
                            deleteItem.IsDeleted = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
