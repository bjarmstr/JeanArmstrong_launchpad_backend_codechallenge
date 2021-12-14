
var QUEUE_URL = 'https://sqs.ca-central-1.amazonaws.com/625915104196/launchpad-db-event-sqs';

var AWS = require('aws-sdk');
var sqs = new AWS.SQS({region : 'ca-central-1'});

exports.handler = function(event, context) {
  var params = {
    MessageBody: JSON.stringify(event),
    QueueUrl: QUEUE_URL
  };
  sqs.sendMessage(params, function(err,data){
    if(err) {
      console.log('error:',"Fail Send Message" + err);
      context.done('error', "ERROR Put SQS");  // ERROR with message
    }else{
      console.log('data:',data.MessageId);
      context.done(null,'');  // SUCCESS 
    }
  });
}