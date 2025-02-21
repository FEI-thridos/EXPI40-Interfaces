The **IOpcUaNode** interface used to mediate a specific node value on the aggregation OPC UA server.
Mediates data:
- string *NodeId* - NodeId of the node on the aggregation OPC UA server,
- object *Value* - the current value of the node,
- DateTime *TimeStamp* - timestamp when the node value was last updated,
- bool *IsVariableCategory* - flag used to quickly find all nodes whose value can change over time, i.e. it is of type VARIABLE.

The **IReadItem** interface has to be implemented by all actuators in the base class of the parent object - the parent object is an empty Unity object that aggregates line part components, e.g. in the case of a conveyor it aggregates conveyor belt, legs...
Mediates data:
- List<IOpcUaNode> *Nodes* - represents a list of nodes that the parent object further conveys to the individual children (parts of the line part).

The **IReadItemChild** interface has to be implemented by all children of the **IReadItem** object. 
Mediates data:
- IReadItem *Parent* - a read-only property that contains a reference to the parent (IReadItem).

The **IWriteItem** interface has to be implemented by all sensors in the base class of the parent object - the parent object is an empty Unity object that aggregates the parts of sensor.
Mediates data:
- string *ObjectName* - the name of the object in Unity, this is assigned to it when it is instantiated in the environment,
- bool *IsOnlyVirtual* - a variable that is used to decide if the sensor has a physical counterpart or is just purely virtual.

The **IWriteItemChild** interface has to be implemented by all children of the **IWriteItem** object. 
Mediates data:
- IWriteItem *Parent* - a read-only property that contains a reference to the parent (IWriteItem).

The **IWriteItemPassedData** interface is used to pass sensor data when an event is triggered when the virtual sensor value changes.
Example:
`EventManager.TriggerEvent("onWriteItemValueChanged", new PassedData : IWriteItemPassedData)`

Mediates data:
- string *ObjectName* - the name of the AAS object, e.g. "ns=11;s=BeamSensor", taken from *Parent*,
- string *AasProperty* - the target property in the OperationalData Submodel in the AAS, a text string, e.g. "Hit" when the opto-sensor is intercepted,
- object *Value* - the value that the sensor writes.
