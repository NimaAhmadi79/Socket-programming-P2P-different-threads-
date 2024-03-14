

# Distributed Rumor Spreading System

## Introduction
This project aims to implement a peer-to-peer system for rumor spreading in a distributed environment. Each user in this system can connect to multiple other users and send commands for execution. It's important to note that only the user initiating the connection can send commands, while the other users receive and execute them. Commands are sent line by line.

## Project Overview
- The project utilizes socket programming to establish connections between peers.
- Each peer is represented by a separate thread to handle concurrent connections.
- Two types of commands are supported: rumor spreading and peer introduction.
  - **Rumor Spreading**: This command transfers a rumor to other peers. If the rumor is already known, the receiver does not react, but if it's new, the receiver forwards it to all connected users.
  - **Peer Introduction**: This command introduces a new peer. If the receiver hasn't previously connected to this peer, it connects and shares all received rumors. The introducing peer must also introduce itself to the new peer. The command format includes the IP address and port number of the introduced peer.

## Usage
- To run the application, you need to clone and enter the code and forms in an ID (preferably Visual Studio) and then run it.
- Users can create peer connections by specifying the IP address and port number of the peer they want to connect to.
- Users can send commands once connected.
- there are some default and random sample rumors and users can add some rumors by sending the new ones.
- remember you should first tap start-server in each peer and then you can connect to them
  - Example:
   ![alt text](https://github.com/NimaAhmadi79/Socket-programming-P2P-different-threads-/blob/master/Capture.PNG)
- Each peer should report its activities by printing messages.

## Important Notes
1. This project heavily relies on programming sockets.
2. Users can connect to multiple peers concurrently. Users must handle other users' requests concurrently, and access to shared data structures should not lead to race conditions or deadlocks.
3. Each user should report all their activities by printing messages.
4. It's crucial to set the IP address for each peer within the localhost domain (127.0.0.1) to facilitate testing and local development.
5. you can not create more than 6 peers

## Dependencies
- The project uses the SimpleTCP library for handling TCP communication.

## Contributing
Contributions are welcome! Please feel free to fork the repository, make changes, and submit pull requests.

## Contact:

For any inquiries, please contact Nima87760@gmail.com




