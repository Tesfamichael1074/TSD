package main

import (
	"fmt"
	"strings"
)

func wordCount(value string) map[string]int {
	input := strings.Fields(value)
	wc := make(map[string]int)
	for _, word := range input {
		_, matched := wc[word]
		if matched {
			wc[word] += 1
		} else {
			wc[word] = 1
		}
	}
	return wc
}

// Main function
func main() {
	input := "betty bought the butter the butter was bitter betty bought more butter to make the bitter butter better"
	result := wordCount(input)
	fmt.Println(result)
}