 public class SIngle_link_list_no_tail
 {

     public NOde_1 Header = null;

     public void push_front(int v)
     {
         NOde_1 n1 = new NOde_1();
         n1.value = v;
         if (Header == null)
         {
             n1.next = null;
             Header = n1;
         }
         else
         {
             n1.next = Header;
             Header = n1;
         }
     }

     public void push_back(int v)
     {
         NOde_1 n1 = new NOde_1();
         n1.value = v;
         if (Header == null)
         {
             n1.next = null;
             Header = n1;
         }
         else
         {
             NOde_1 p = Header;
             while (p.next != null)
             {
                 p = p.next;
             }
             n1.next = null;
             p.next = n1;
         }
     }

     public void push_middle(int v)
     {
         NOde_1 n1 = new NOde_1();
         if (is_empty())
         {
             n1.value = v;
             n1.next = null;
             Header = n1;
         }
         else
         {
             int c = count();
             c = c / 2;
             NOde_1 p = Header;
             int i = 1;
             while (i < c)
             {
                 p = p.next;
                 i++;
             }
             n1.value = v;
             n1.next = p.next;
             p.next = n1;
         }
     }

     public void display()
     {
         NOde_1 p = Header;
         while (p != null)
         {
             Console.WriteLine(p.value);
             p = p.next;
         }
     }

     public void print_reverse()
     {

     }

     public int count()
     {
         int c = 0;
         NOde_1 p = Header;
         while (p != null)
         {
             p = p.next;
             c++;
         }
         return c;
     }

     public int top_front()
     {
         if (Header == null)
             return 0;
         else return Header.value;
     }

     public int top_back()
     {
         if (Header == null)
             return 0;
         if (Header.next == null)
             return Header.value;
         if (Header.next.next == null)
             return Header.next.value;
         else
         {
             NOde_1 p = Header;
             while (p.next.next != null)
                 p = p.next;
             return p.next.value;
         }

     }

     public void pop_front()
     {
         if (is_empty())
             return;
         Header = Header.next;
     }

     public void pop_back()
     {
         if (is_empty())
             return;
         if (Header.next == null)
             Header = null;
         else
         {
             NOde_1 p = Header;
             while (p.next.next != null)
             {
                 p = p.next;
             }
             p.next = null;
         }
     }

     public void pop_value(int value)
     {
         if (is_empty())
             return;
         if (!find(value))
             return;
         if (Header.value == value)
             Header = null;
         else if (Header.next.value == value)
             Header.next = Header.next.next;
         else
         {
             NOde_1 p = Header;
             while (p != null && p.next.value != value)
                 p = p.next;
             return;
         }

     }
     public void pop_middle()
     {

     }

     public bool find(int v)
     {
         if (is_empty())
             return false;
         else
         {
             NOde_1 p = Header;
             while (p != null)
             {
                 if (p.value == v)
                     return true;
                 p = p.next;
             }
         }
         return false;
     }

     public bool is_empty()
     {
         return Header == null;
     }

     public void destroy()
     {
         Header = null;
     }

     public SIngle_link_list_no_tail copy()
     {
         SIngle_link_list_no_tail s1 = new SIngle_link_list_no_tail();
         s1.Header = Header;
         return s1;
     }
     public bool equal_1(SIngle_link_list_no_tail s1,SIngle_link_list_no_tail s2)
     {
         if (s1.count == s2.count)
         {
             NOde_1 nOde_1 = s1.Header;
             NOde_1 nOde_11 = s2.Header;
             while (nOde_1 != null)
             {
                 if (nOde_1.value != nOde_11.value)
                     return false;
                 nOde_1 = nOde_1.next;
                 nOde_11 = nOde_11.next;
             }
             return true;
         }
         return false;
     }
     public void sort(int value)
     {


     }
 }


 public class SIngle_link_list_with_tail
 {

     public NOde_1 Header = null;
     public NOde_1 tail = null;

     public void push_front(int v)
     {
         NOde_1 n1 = new NOde_1();
         n1.value = v;
         if (Header == null)
         {
             n1.next = null;
             tail = Header = n1;
         }
         else
         {
             n1.next = Header;
             Header = n1;
         }
     }

     public void push_back(int v)
     {
         NOde_1 n1 = new NOde_1();
         n1.value = v;
         if (Header == null)
         {
             n1.next = null;
             tail = Header = n1;
         }
         else
         {
             n1.next = null;
             tail.next = n1;
             tail = n1;
         }
     }

     public void display()
     {
         NOde_1 p = Header;
         while (p != null)
         {
             Console.WriteLine(p.value);
             p = p.next;
         }
     }

     public int count()
     {
         int c = 0;
         NOde_1 p = Header;
         while (p != null)
         {
             p = p.next;
             c++;
         }
         return c;
     }

     public void pop_front()
     {
         if (is_empty())
             return;
         if (Header.next == null)
         {
             tail = Header = null;
         }
         else
             Header = Header.next;
     }

     public void pop_back()
     {
         if (is_empty())
             return;
         if (Header.next == null)
         {
             tail = Header = null;
         }
         else if (Header.next.next == null)
         {
             Header.next = null;
             tail = Header;
         }
         else
         {
             NOde_1 p = Header;
             while (p.next.next != null)
             {
                 p = p.next;
             }
             p.next = null;
             tail = p;
         }
     }

     public bool find(int v)
     {
         if (is_empty())
             return false;
         else
         {
             NOde_1 p = Header;
             while (p != null)
             {
                 if (p.value == v)
                     return true;
                 p = p.next;
             }
         }
         return false;
     }

     public bool is_empty()
     {
         return Header == null;
     }

     public void destroy()
     {
         tail = Header = null;
     }
 }