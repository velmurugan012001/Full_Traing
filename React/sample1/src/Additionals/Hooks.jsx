import React,{useState,useEffect} from "react";
const Hooks=()=>{
    const[count,setCount] =useState(0);
    const[data,setDtata]=useState(null);

    const incrementCount =() =>{
        setCount(prevCount)
    }
    useEffect(()=>
    {
        fetchDate();
    }
    const fetchDate = ()=>{
        setTimeout(()=>{
            setTimeout(()=>{
                const newData='Date for count'${count};
                setDtata count 3000
            })
        })
    }
    );
    return(
        <div>
            <p>Count :</p>
            <button onclick={incrementCount}>click</button>
            <p>{date ? date :"Fetching..."}</p>
        </div>
    );
};
export default Hooks;