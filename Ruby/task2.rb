
#  Task 2 #1
def min_max(val)
  sort_list = val.sort
  total_sum = sort_list.inject { |mul, n| mul + n }
  min = total_sum - sort_list.last
  max = total_sum - sort_list.first
  puts "#{min} #{max}"
end 

min_max([2, 8, 3, 5, 1])
min_max([1, 2, 3, 4, 5])


#  Task 2 #2
def decimal(val)
  v = 0
  count = 0
  allowed = ['0', '1']
  val.reverse.each_char{ |e| 
    if  allowed.include?(e)
      v = v + e.to_i * 2**count
      count +=1 
    else
      raise ArgumentError.new 'this is not a binary number'
    end
    # puts '------'
  }
  puts v
end

decimal('111011000110')

#  Task 2 #3
def count_words(val)
  result = {}
  val.split.map { |e|     
    if not result[e]
      result[e] = val.split.count(e)
    end
  }
  puts result
end 

count_words("olly olly come here free")


#  Task 2 #4
def pangram?(val)
  # removing spaces and .
  alphabets = val.tr(' ', '').chop
  # sorting the chars and removing duplicates
  alphabets = alphabets.downcase.chars.sort.uniq
  if alphabets.length == 26
    true
  else 
    false
  end
  
end

puts pangram?("The quick brown fox jumps over the lazy dog.")







