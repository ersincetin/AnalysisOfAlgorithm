#include <cstdlib>
#include <iostream>

using namespace std;
class node{
      private:
         int _value;
         node *_next;
      
      public:
         node(int value=10){_value=value;_next=0;}
         
         int getV(){return _value;}
         
         void add(int i){
              if(_next !=0 ){_next=new node(i);}
              else{
                 node *n = this;  
                 while(n->_next!=0){
                     n = n->_next;
                 }
                 n->_next = new node(i);
              }
         }
         int len(){
             int s=1;
             node *n = _next;
             while(n!=0){
                  s++;
                  n = _next->_next;
             }
         }
         
};

int main(int argc, char *argv[])
{
    node n1 = node(10);
    cout<<endl<<n1.getV()<<endl;
    
    node n2 = node(-10);
    cout<<endl<<n2.getV()<<endl;
    
    n1.add(20);
    n1.add(120);
    n1.add(220);
    n1.add(320);
    cout<<endl<<n1.len()<<endl;
    system("PAUSE");
    return EXIT_SUCCESS;
}
