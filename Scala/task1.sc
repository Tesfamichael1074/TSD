
object scala_basic {

    def convertString(source: String): String = {
        source.take(source.length() - 4) + source.drop(source.length() - 4).toUpperCase()
    }

   def main(args: Array[String]): Unit = {
      println("First Test:  Abcdefghi"); 
      println("Result -> " + convertString("Abcdefghi")); 
      println("Second Test:  abcd"); 
      println("Result -> " + convertString("abcd")); 
    }

  }