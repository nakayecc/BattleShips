import React, {Component} from "react";
import axios from "../axios/axios";

export default class Square extends Component {

    hitSquare = (clickedSquare) => {
        
        
        let temp = this.props.squares;
        temp.map(square => {
                if(clickedSquare.coordinates === square.coordinates){
                    square.fieldType = 0;
                    axios.put('/board/'+this.props.squareId, square)
                        .then(response => {
                            console.log(response.status);
                        })
                        .catch(function (error) {
                            // handle error
                            console.log(error);
                        })
                        .finally(function () {
                            // always executed
                        });
                }
        });
        let hitSquaree = this.props.hitSquaree;
        hitSquaree(temp);
    };
    
        
    

    render() {
        let isShip = "S";
        let ocean = "~~";
        
        return (
            <div className="col-xs-1-10 text-center square">
                

                <p className="squareValue" onClick={this.hitSquare.bind(Square,this.props.square)}>{this.props.square.fieldType === 0 ? isShip : ocean}</p>

            </div>

        )
    }

}