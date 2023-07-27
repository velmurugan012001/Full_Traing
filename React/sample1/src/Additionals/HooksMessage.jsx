import React,{useState,useEffect} from "react";
const HookMessage=()=>{
    return(
        <div>
            <label>Enter your name</label>
            <input type="text" value={name}
            onChange={handleNameChange}/>

        </div>
    )

}
export default HookMessage;