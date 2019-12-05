import React, {Component, Fragment} from "react";
import axios from "../axios/axios";
import Square from "./Square";

export default class Board extends Component {
    state = {
        squares: [],
        isLoading: true
    };

    componentDidMount() {
        this.getSquares().then(response => {
            this.setState({squares: response});
            this.setState({isLoading: false});
        });

    }

    getSquares = () => {
        return axios.get('/board')
            .then(response => {
                return response.data;
            });
    };

    hitSquare = async (clickedSquare) => {
        this.state.squares.map(square => {
            if (clickedSquare.coordinates === square.coordinates) {
                axios.post('board', {
                    row: square.coordinates.row,
                    column: square.coordinates.column
                })
                    .then(function (response) {
                        console.log(response);
                    })
                    .catch(function (error) {
                        console.log(error);
                    });

            }
        });
    };
    updateSquare = (clickedSquare) => {
        this.setState({isLoading: true});
        this.hitSquare(clickedSquare);
        setTimeout(function () {
            this.getSquares().then(response => {
                this.setState({squares: response});
                this.setState({isLoading: false});
            });
        }.bind(this), 50)
    };



    render() {
        let counter = 0;
        let content = this.state.squares.map(square =>
            <Square
                square={square}
                squareId={counter++}
                hitSquaree={this.updateSquare}
                key={counter++}
                isLoading={this.state.isLoading}
            />);
        return (
            this.state.isLoading === false ? content : <div className="spinner-border" role="status">
                <span className="sr-only">Loading...</span>
            </div>
        )
    }
}