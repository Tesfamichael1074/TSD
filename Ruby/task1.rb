
def local_factorial(val)
  if val < 0
    raise 'cannot count factorial for negative number'
  end
  some = 1..val
  some = some.inject { |mul, n| mul * n }
end 


module InstanceModule
  def square
    sq = self*self
  end
end 

module ClassModule
  def sample(val)
    if val < 0
      raise ArgumentError.new 'Value must be positive integer'
    end
    val.times.map { rand(val) }
  end 
  alias_method "random", :sample
end 

# Monkey patching
class Integer
  include InstanceModule
  extend ClassModule
  def factorial
    local_factorial(self)
  end
end

# Task 1 #1
puts 'Task 1 #1'
puts local_factorial(5)

# Task 1 #2
puts 'Task 1 #2'
puts 5.factorial

# Task 1 #3
puts 'Task 1 #3'
puts 5.square

# Task 1 #4
puts 'Task 1 #4'
puts Integer.sample(5)

# Task 1 #5
puts 'Task 1 #5'
puts Integer.random(5)








