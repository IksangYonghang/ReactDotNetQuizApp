import React, { createContext, useContext, useEffect, useState } from 'react'
import { json } from 'react-router-dom';

export const stateContext = createContext();
    
const getFreshContext = () => {
    const storedData = localStorage.getItem('context');
    let parsedData = null;
    const initial = {
      participantId: 0,
      timeTaken: 0,
      selectedOptions: [],
    };
  
    try {
      parsedData = JSON.parse(storedData);
    } catch (error) {
            parsedData = initial;
    }
  
    return {...initial, ...parsedData};
  };
  //another process to get parsedData
  /*
  const getFreshContext = () =>{
    if(localStorage.getItem('context')===null)
    localStorage.setItem('context', JSON.stringify({       
        participantId: 0,
        timeTaken:0,
        selectOptions:[]
    }))
    return JSON.parse(localStorage.getItem('context'))   
}
*/

// useStateContext.js




export default function useStateContext(){
    const {context, setContext} = useContext(stateContext)
    return {context,
         setContext: obj => {setContext ({...context, ...obj })},
         resetContext : () =>{
          localStorage.removeItem('context')
          setContext(getFreshContext())
         }
        };
}

export  function ContextProvider({children}) {
    const [context, setContext] = useState(getFreshContext())
    
    
useEffect(()=>{
    localStorage.setItem('context', JSON.stringify(context))
}, [context])

  return (
    <stateContext.Provider value={{context, setContext}}>
        {children}
    </stateContext.Provider>
  )
}
