


class Clock
    attr_reader :hour, :minute , :second 
    
    def initialize(hour, minute, second)
      @hour, @minute, @second = hour, minute, second
    end
    
    def print
      puts "#{self.hour}:#{self.minute}:#{self.second}"
    end
  
    def ==(other_obj)
      self.hour == other_obj.hour and self.minute == other_obj.minute and self.second == other_obj.second
    end
  
    # Add minutes to the class
    def +(new_min)
      
      @hour += (new_min / 3600).to_i
      new_min = new_min % 3600
      @minute += (new_min / 60).to_i
      @second += new_min % 60
      self
    end
  
    # Current time 
    def self.now()
      Time.now
    end
  
    # Measure running time for a block of code 
    def self.measure_time
      start = self.now
      yield
      finish = self.now
      diff = finish - start
      puts "#{diff.to_i} secs"
    end
    
  end 
  
# Monkey patching
class Integer
    def hours
        self * 60 * 60
    end

    def minutes
        self * 60
    end

    def seconds
        self
    end
end
  
  
# Task 3 #1
clock = Clock.new(10, 0, 0)
clock.print  # The current time is 10:00:00
clock += 30
clock.print  # The current time is 10:30:00
clock == Clock.new(10, 30, 0)  # true


# Task 3 #2
Clock.measure_time do
puts "Something is happening here"
sleep 3
end

# Task 3 #3
clock = Clock.new(10, 0, 0)
clock += 2.hours
clock.print  