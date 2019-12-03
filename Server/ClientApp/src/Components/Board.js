import React, {Component} from "react";
import axios from "../axios/axios";
import Square from "./Square";
export default class Board extends Component {
    
    constructor(props){
        super(props);
    }

    state = {
        squares: []
    };

  componentDidMount() {
      axios.get('/board')
          .then(function (response) {
              // handle success
              console.log(response);
          })
          .catch(function (error) {
              // handle error
              console.log(error);
          })
          .finally(function () {
              // always executed
          });
  }


    render() {


        return(

            this.state.squares.map(square =>
                <Square
                    square={square}
                key={square.id}/>
            )
        );

    }

}