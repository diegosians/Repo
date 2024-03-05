import React from "react"
import Card from "./Card"


const CardList = ({robots}) =>{
    const cardComponent = robots.map((user, index)=>{
    return (
    <Card 
    key={index} 
    id={robots[index].id} 
    nome={robots[index].nome} 
    email={robots[index].email}/>)
    })
    return (
        <div>
            {cardComponent}
        </div>
    )
}

export default CardList