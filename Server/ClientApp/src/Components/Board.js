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
                this.setState({squares: response.data.board})
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
        return (
            this.state.squares.map(square =>
                <Square
                    square={square}/>
            )
        )
    }
}