import React, {Component} from "react";
import axios from "../axios/axios";
import Square from "./Square";

export default class Board extends Component {
    state = {
        squares: []
    };

    componentDidMount() {
        axios.get('/board')
            .then(response => {
                this.setState({squares: response.data});
            })
            .catch(function (error) {
                // handle error
                console.log(error);
            })
            .finally(function () {
                // always executed
            });
    }
    hitSquaree = (squares) => {
        console.log("board");
        this.setState({squares : squares});
        
    };


    render() {
        let counter = 1;
        return (
            this.state.squares.map(square =>
                <Square
                    square={square}
                    squareId = {counter++}
                    hitSquaree = {this.hitSquaree}
                    squares = {this.state.squares}
                    key={counter++}
                    />
            )
        )
    }
}