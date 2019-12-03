import React, {Component} from "react";
import Board from "./Board";


export default class Home extends Component {

    render() {
        return (
            <div className="row">
                <div className="col-lg-12 text-center">
                    <h1>BattleShips</h1>
                </div>
                <div className="container gameBoard">
                    <div className="row">
                        <div className="col-lg-5">
                            <h2 className="text-center">Your Board</h2>
                            <Board/>
                        </div>
                        <div className="col-lg-2">
                            <h2 className="text-center">Game Info</h2>
                            <div className="col-lg-12 infoBox text-center">
                                <p>Actual Turn : Player1</p>
                                <p>Time : 10:59</p>
                                <p>Message : U hitted ship!</p>

                            </div>
                        </div>
                        <div className="col-lg-5">
                            <h2 className="text-center">Enemy Board</h2>
                            <Board/>
                        </div>
                    </div>


                </div>




            </div>
        )
    }

}