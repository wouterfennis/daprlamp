import flask
from flask import request, jsonify
from flask_cors import CORS
import json
import sys

app = flask.Flask(__name__)
CORS(app)

@app.route('/dapr/subscribe', methods=['GET'])
def subscribe():
    subscriptions = [{'pubsubname': 'pubsub', 'topic': 'buildname', 'route': 'buildname'}]
    return jsonify(subscriptions)

@app.route('/buildname', methods=['POST'])
def buildname_subscriber():
    ##Change state and lamp here

app.run()