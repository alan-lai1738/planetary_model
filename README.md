# Planetary Model Project: Simulation from Sun to Mars

## Running the Program
- **Download**: Clone the repository or download the ZIP file.
- **Execution**: Launch the program by opening the EXE file.

## Project Overview
The Planetary Model Project is a hands-on simulation exploring pivoted transformations, scene nodes, and hierarchical structures without utilizing Unity's default shaders. Try out my Planetary Model graphics program by running the EXE file!

### Objective
This project aims to demonstrate a comprehensive understanding of scene manipulation and hierarchy in a graphical environment.

### Features and Implementation
1. **Scene Hierarchy**: 
   - Construct a detailed scene hierarchy with at least four node generations and two sibling nodes at one level.
   - Ensure each node connects to primitives from adjacent generations.
   - Include intuitive controls for node selection and transformation.

2. **Reusable Hierarchy**:
   - Implement a reusable hierarchy system by duplicating and integrating a subpart of the hierarchy.

3. **AxisFrame Visualization**:
   - Develop a feature to display an axis frame at the pivot of the selected node, following the node's orientation.

4. **Implementation Guidelines**:
   - Utilize the 451Shader for all primitives, managing model transformations explicitly.

5. **Pivoted Primitive Transform**:
   - Create continuous rotation for various primitives (sphere, cube, capsule) at different levels within the hierarchy.

6. **Reset Functionality**:
   - Integrate a reset feature to revert the scene to its initial configuration.

### Development Tips
- Design for a 1920x1080 resolution, ensuring the application is windowed and resizable.
- Focus on the hierarchy aspect more than the UI design.
- Regular project backups are advised.

### Project Evaluation
Your project will be assessed on the following aspects:
1. Depth and complexity of the Scene Hierarchy.
2. Implementation of the Reusable Hierarchy.
3. Innovation in Pivoted Primitive Transform and Animation.
4. Functionality of the Reset Feature.
5. Adherence to the specified Implementation Guidelines.

### Additional Information
This project is a personal interpretation of an academic assignment, modified and extended to fit a standalone project format.

### Note
Be mindful of Unity's Frustum culling, especially given the modifications to the vertex shader transform.





### Note
Be aware of Unity Frustum culling due to customized vertex shader transform.
