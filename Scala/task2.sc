object Scala_Array {
  def find_min_subarray_sum(nums: Array[Int], count:Int): Array[Int] = {
    
    var sub_arr_sum = 0;
    var min_sub_arr = Integer.MAX_VALUE;
    var last = 0;
    var result = new Array[Int](3)

    for ( i<- 0 to nums.length-1) {
      sub_arr_sum += nums(i);

      if (i + 1 >= count) {
				if (min_sub_arr > sub_arr_sum) {
					min_sub_arr = sub_arr_sum 
					last = i;
				}

				sub_arr_sum -= nums(i + 1 - count);
			}

    }

    result(0) = last - count + 1;
    result(1) = last;
    result(2) = min_sub_arr;
    result;
  }

  def main(args: Array[String]): Unit = {
    val nums = Array(7, 9, 5, 4, 5, 1, 7, 45, 90, 0);
    println("Original array:")
    for (x <- nums) {
      print(s"${x}, ")
    }

    val result = find_min_subarray_sum(nums, 4);
    println(s"\nThe final result from ${result(0)} to ${result(1)} and sum is: ${result(2)}");  
  }
}



