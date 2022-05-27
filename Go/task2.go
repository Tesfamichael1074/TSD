package main

import (
	"fmt"
	"strconv"
)

func FibonacciRecursion(n int) int {
	if n <= 1 {
		return n
	}
	return FibonacciRecursion(n-1) + FibonacciRecursion(n-2)
}

// Main function
func main() {

	// Fibonacci loop
	for i := 0; i <= 9; i++ {
		fmt.Print(strconv.Itoa(FibonacciRecursion(i)) + " ")
	}
}
