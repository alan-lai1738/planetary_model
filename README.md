# GitHub Repository: Planetary Model Simulation (Sun to Mars)

## Instructions for Running the Program
- **Download Method**: Download the ZIP file or clone the repository.
- **Execution**: Open the EXE file after extraction.

## Assignment MP5: Scene Hierarchy and Graph Analysis
**Submission Deadline**: Refer to the course website.

### Purpose
To enhance understanding of pivoted transformations, scene nodes, and hierarchy.

### Methodology
Develop an application for scene manipulation, focusing on node selection and hierarchy adjustment.

### Assignment Requirements
1. **Scene Hierarchy**: 
   - Construct a scene hierarchy with a minimum of four generations (e.g., Torso, UpperArm, Arm, Hand) and at least two siblings in one generation.
   - Each node should be connected to primitives from both previous and subsequent generations, including at least one sphere at joint locations.
   - User-friendly selection and transformation of scene nodes.
   - Intuitive hierarchy behavior.

2. **Hierarchy Reusability**:
   - Demonstrate reusability by duplicating and parenting a sub-part of the hierarchy.

3. **AxisFrame Feature**:
   - Feature to display an axis frame at the pivot of the selected node.

4. **Implementation Constraints**:
   - Use the 451Shader for all primitives. Avoid default Unity shaders and specific Unity matrices.

5. **Pivoted Primitive Transform**:
   - Continuous rotation for different primitives (sphere, cube, capsule) at various hierarchy levels.

6. **Reset Functionality**:
   - A reset button to revert the scene to its initial state.

### Additional Tips
- Target a resolution of 1920x1080, with windowed and resizable settings.
- Focus more on hierarchy development than UI.
- Regular backups recommended.

### Evaluation Criteria
Assessment based on:
1. Scene Hierarchy
2. Reusable Hierarchy Implementation
3. Pivoted Primitive Transform and Animation
4. Reset Functionality
5. Submission Guidelines Adherence

### Final Grade Contribution
This assignment contributes 11% to the final grade.

### Note
Be aware of Unity Frustum culling due to customized vertex shader transform.
