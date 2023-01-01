namespace ComplexNumbers;

public class Complex{

    private int real;
    private int img;

    public Complex(){
        this.real = 0;
        this.img = 0;       
    }

    public Complex(int real, int img){
        this.real = real;
        this.img = img;
    }

    public int Real{
        get{return this.real;}
        set{this.real = value;}
    }

    public int Img{
        get{return this.img;}
        set{this.img = value;}
    }

    ~Complex(){

    }

    public static Complex operator+(Complex c1, Complex c2){
        Complex temp = new Complex();
        temp.Real = c1.Real + c2.Real;
        temp.Img = c1.Img + c2.Img;
        return temp;
    }
}