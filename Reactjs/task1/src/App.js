import logo from './logo.svg';
import './App.css';
import { React, useState } from 'react'

        
function App() {
  const [counter, setCounter] = useState(0);

  //increase counter
  const increase = () => {
    setCounter(count => count + 1);
    };

    //decrease counter
    const decrease = () => {
    setCounter(count => count - 1);
    };


  return (
    <div className="App">
      <div className="cont">
                    <div className="tittle">{counter}</div>
                    <div className="btns">
                        <div onClick={() => increase()} className="number">+</div>
                        <div onClick={() => decrease()} className="number">-</div>
                    </div>
                </div>
    </div>
  );
}

export default App;
