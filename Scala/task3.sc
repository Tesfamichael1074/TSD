object Scala_String {
  def test(stng: String): Boolean = {
  var l = stng.length;
  var st_the = 0;
  var st_is = 0;
  for (i <- 0 to l-1) 
  {
    if (i < l - 2) {

    var tmp = stng.substring(i,i+3);
    if (tmp.equals("the"))
        st_the = st_the +1;
    }
    if (i < l - 1) {

    var tmp2 = stng.substring(i,i+2);
    if (tmp2.equals("is"))
        st_is = st_is + 1;
    }
  }
  if (st_the == st_is)
    return true;
  else
    return false;
  }
  def main(args: Array[String]): Unit = {
      var str1 =  "Thisisthethesis";
      println("The given string is: "+str1);
      println("Are the appearance of 'the' and 'is' equal? "+test(str1));
    
      str1 =  "Thisisthethes";
      println("The given string is: "+str1);
      println("Are the appearance of 'the' and 'is' equal? "+test(str1));
  }
}