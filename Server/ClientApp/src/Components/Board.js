import React, {Component, Fragment} from "react";
import axios from "../axios/axios";
import Square from "./Square";

export default class Board extends Component {
    state = {
        squares: [],
        isLoading: true
    };
    constructor() {
        super();
        this.getSquares();
    }


    getSquares = () => {
        axios.get('/board')
            .then(response => {
                this.setState({squares: response.data});
                this.setState({isLoading : false})
            })
            .catch(function (error) {
                // handle error
                console.log(error);
            })
            .finally(function () {
                // always executed
            });
    };
    hitSquaree = () => {
        this.setState({isLoading : true});
        let czas = setInterval(() =>
            {
                axios.get('/board')
                    .then(response => {
                        this.setState({squares: response.data});
                        this.setState({isLoading : false})
                    })
                    .catch(function (error) {
                        // handle error
                        console.log(error);
                    })
                    .finally(function () {
                        // always executed
                    });
            }
            , 200);


        console.log(this.state.squares);
        
    };



    render() {
        let counter = 1;
        console.log(this.state.isLoading);
        let content = this.state.squares.map(square =>
            <Square
                square={square}
                squareId={counter++}
                hitSquaree={this.hitSquaree}
                squares={this.state.squares}
                key={counter++}
            />);
        return (
            this.state.isLoading === false ? content : <div className="spinner-border" role="status">
                <span className="sr-only">Loading...</span>
            </div>
        )
    }
}