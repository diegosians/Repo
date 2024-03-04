import React, {Component} from "react"
import "./Hello.css"
class Hello extends Component{
    render(){
        return (
            <div class="literata-div1">
        <p> {this.props.informazione}</p>
        <h1>Levis</h1>
            </div>
        )
    }
}

export default Hello