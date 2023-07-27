import React from "react"
import Button from "./Button"
const ModuleHanding =()=>{
    const handleClick =()=>{
        console.log('Bottun Click')
    }
  return(
   <div>
    <Button onclick={handleClick}
    text="click !!!"></Button>
   </div>
  );
}
export default ModuleHanding;