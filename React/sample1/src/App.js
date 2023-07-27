import logo from './logo.svg';
import './App.css';
import ControlledCounter from './Additionals/ControlledCounter';
import BoundedComponent from './Additionals/BoundedComponent';
import Button from './Additionals/Button';
import Header from './Additionals/Header';

function App() {
  const expenses = [
    { edate: new Date(2023, 6, 19), expense:"Rent",amount:1000,},
    { edate: new Date(2023, 6,19),expense:"Food",ampount:100,}
  ];
  return (
  
      <div>
        <Header></Header>
        <ControlledCounter></ControlledCounter>
        <BoundedComponent></BoundedComponent>
         <Button></Button>
         
      </div>
  )
}

export default App;
