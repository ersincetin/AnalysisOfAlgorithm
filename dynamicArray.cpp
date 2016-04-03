#include <cstdlib>
#include <iostream>

using namespace std;
class dynamicArray{
      public:
      dynamicArray(int initSize=0):theSize(initSize),theCapacity(initSize + 1 ),s(0)
      {
          object = new int[theCapacity];
      }
      int size(){return theCapacity;}
      void add(int x){
           if(s==size()) resize();
           object[s] = x ;
           s++;
      }
      int resize(){
          cout<<"............................"<<endl;
          cout<<"yer degisimi yapiliyor"<<endl;
          int s = theSize;
          int *eski_sayilar = object ;
          
          object = new int[theCapacity*2];
          for(int k = 0 ; k<s ; k++){
               object[k] = eski_sayilar[k];        
          }
          theSize = s ;
          theCapacity =theCapacity*2;
      }
      
      private:
        int theSize;
        int s;
        int theCapacity;
        int *object;
              
};
int main(int argc, char *argv[])
{
    dynamicArray myD = dynamicArray(10);
    
    for(int k =0 ; k<100 ; k++){
            myD.add(4);
    }
    cout<<myD.size()<<endl;
    
    system("PAUSE");
    return EXIT_SUCCESS;
}
