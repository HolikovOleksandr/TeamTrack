import 'package:team_track_app/core/resources/responce_state.dart';
import 'package:team_track_app/domain/entities/emploee.dart';
import 'package:team_track_app/domain/repository/employee_repository.dart';

class EmployeeRepositoryImpl implements EmployeeRepository{
  @override
  Future<ResponceState<List<Employee>>> createEmployee(Employee newEmployee) {
    // TODO: implement createEmployee
    throw UnimplementedError();
  }

  @override
  Future<ResponceState<List<Employee>>> deleteEmployee(int id) {
    // TODO: implement deleteEmployee
    throw UnimplementedError();
  }

  @override
  Future<ResponceState<List<Employee>>> getAllEmployees() {
    // TODO: implement getAllEmployees
    throw UnimplementedError();
  }

  @override
  Future<ResponceState<Employee>> getEmployeById(int id) {
    // TODO: implement getEmployeById
    throw UnimplementedError();
  }

  @override
  Future<ResponceState<Employee>> updateEmployee(Employee updatedEmployee) {
    // TODO: implement updateEmployee
    throw UnimplementedError();
  }

}