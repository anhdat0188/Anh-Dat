using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List<T>
    {
        Element<T> head;
        internal Element<T> Head
        {
            get{return head;}
            set{head=value;}

        }
        //tạo hàm insertfist
        //in danh sách trong list
       
        public void Addfirst(Element<T> e)
        {
                e.Next=head;
                this.head=e;
        }


   
        public List()
        {
            this.head= null;
        }
        public void printList()
        {
            Element<T> point = head;
            while(point.Next != null)
            {
                Console.WriteLine(point.Data);
                point = point.Next;
            }
        }
    }
}
