namespace Triangles.Models
{
  public class TrianglesVariable
  {
    private string _sideOne;
    private string _sideTwo;
    private string _sideThree;

    private double side1;
    private double side2;
    private double side3;


    public string GetSideOne()
    {
      return _sideOne;
    }
    public void SetSideOne(string newSideOne)
    {
      _sideOne=newSideOne;
    }
    public string GetSideTwo()
    {
      return _sideTwo;
    }
    public void SetSideTwo(string newSideTwo)
    {
      _sideTwo=newSideTwo;
    }
    public string GetSideThree()
    {
      return _sideThree;
    }
    public void SetSideThree(string newSideThree)
    {
      _sideThree=newSideThree;
    }

    public string GetTriangleType()
    {
      side1=double.Parse(_sideOne);
      side2=double.Parse(_sideTwo);
      side3=double.Parse(_sideThree);

      if (side1 >(side2 + side3) || side2 > (side1 + side3) || side3> (side1 + side2))
      {
        return "not a valid Triangle";
      }
      else if (side1 == side2 && side1==side3 && side2==side3){
        return "equilateral";
      }
      // else if (side1 == side2 == side3)
      // {
      //   return "equilateral";
      // }
      else if (side1 == side2 || side2 == side3 || side1 == side3)
      {
        return "isosceles";
      }
      else {
        return "scalene";
      }
    }
  }
}
